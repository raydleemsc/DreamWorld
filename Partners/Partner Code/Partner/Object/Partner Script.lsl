
//:AUTHOR: Digiworldz.com
//:DESCRIPTION: Opensim Partnership program
//: MODS by Fred Beckhusen for YEngine
//:CODE:
// Put this in a box. When two people touch it, they can make a partership.

// A SETTING YOU SHOULDSET FOR SECURITY
// Set this to your Unique grid identifier from the Settings panel.
string PW = "";

// CODE follows, the rest of this should probably not be modified.
// If you want to  see a lot of messages, set this to TRUE
integer debug = FALSE;

// variables
string URL = "http://127.0.0.1";
// Default = 8001 for Dreamgrid. :80 or blank for other grids
string PORT = ":8001";

// How long you have to convince him/her  to click the box
float TIMEOUT = 30.0; // seconds


list PAR = [];
key id1; // 1st user
string name1; // 1st user
key id2; // 2nd user
string name2; // 2nd user
key id3; // partner of 2nd user
string name3; // partner of 2nd user

key http_request_id1; // get_partner; 1st user
key http_request_id2; // begin: get_partner; 2nd user
key http_request_id3; // begin: set_partner; 1st user
key http_request_id4; // begin: set_partner; 2nd user
key http_request_id5; // dissolve: set_partner; 1st user
key http_request_id6; // dissolve: set_partner; 2nd user


DEBUG(string msg) {
    if (debug) {
        llSay(0,msg);
    };
}

// Just for debugging.
integer fakeID = FALSE;
key UUID1 = "da5253d5-f973-4bea-a65d-4185d3944ad0";
string AName1= "Test User";
key UUID2 = "352008bb-e739-4c2f-a712-15033dfeae86";
string AName2= "Test User2";
// Remove this function - used to debug in LSLEditor

//string osGetGridGatekeeperURI() {
//    return "http://localhost";
//}


string left(string src, string divider) {
    integer index = llSubStringIndex( src, divider );
    if(~index)
        return llDeleteSubString( src, index, -1);
    return src;
}
string right(string src, string divider) {
    integer index = llSubStringIndex( src, divider );
    if(~index)
        return llDeleteSubString( src, 0, index + llStringLength(divider) - 1);
    return src;
}
// default state
default {
    state_entry()    {
        DEBUG("state Default");
        //Grid Gatekeeper Uri
        URL = "http:" + left(right(osGetGridGatekeeperURI(),":"),":");
        DEBUG(URL);

        llSetText("Click here to begin or\ndissolve partnership", <1,1,1>, 1);
    }
    touch_start(integer num_detected)     {
        id1 = llDetectedKey(0);
        name1 = llDetectedName(0);

        if (fakeID) {
            id1 = UUID1;
            name1 = AName1;
        }
        
        string req = URL + PORT + "/get_partner?PW=" + llEscapeURL(PW) + "&User=" + (string)id1;
        DEBUG(req);
        http_request_id1 = llHTTPRequest(req, PAR, "");
    }

    http_response(key request_id, integer status, list metadata, string body)    {

        if (request_id == http_request_id1) {
            DEBUG("http_request_id1");
            // get_partner; 1st user
            DEBUG("Partner = '" + body + "'");
            id2 = (key)body;
            name2 = osKey2Name(id2);
            
//            if (!name2) name2 = (string)id2;
    
            if (id2 == NULL_KEY || id2 == "")
            {
                llSay(0, name1 + ", you have no partnership at the moment");
                state begin_partnership;
            } else {
                llSay(0, name1 + ", your partner is " + name2);
                state dissolve_partnership;
            }
        } 
    }
}

state begin_partnership{
    state_entry()    {
        DEBUG("state begin_partnership");
        llSetText("Future partner of\n" + name1 + "\nplease click here", <1,1,1>, 1.0);
        llSay(0,"Future partner of " + name1 + ", please click the box");
        llSetTimerEvent(TIMEOUT);
    }

    timer()    {
        llSay(0, "Timeout, please try again");
        llSetTimerEvent(0.0);
        state default;
    }

    http_response(key request_id, integer status, list metadata, string body)    {

        if (request_id == http_request_id2) {
            DEBUG("http_request_id2");
            // begin: get_partner; 2nd user
            id3 = (key)body;
            DEBUG("Partner = " + body);
    
            name3 = llGetDisplayName(id3);
            if (!name3) {
                name3 = (string)id3;                
            }
    
            if (id3 == NULL_KEY)
            {
                string req = URL + PORT  + "/set_partner?PW=" + llEscapeURL(PW) + "&User=" + (string)id1 + "&Partner=" + (string)id2;
                DEBUG(req);
                http_request_id3 = llHTTPRequest(req, PAR, "");
            } 
        } else  if (request_id == http_request_id3) {
                DEBUG("http_request_id3");
            // begin: set_partner; 1st user
            string req = URL +PORT + "/set_partner?PW=" + llEscapeURL(PW) + "&User=" + (string)id2 + "&Partner=" + (string)id1;
            DEBUG(req);
            http_request_id4 = llHTTPRequest(req, PAR, "");
        } else if (request_id == http_request_id4) {
            DEBUG("http_request_id4");
            // begin: set_partner; 2nd user
            llSay(0, name1 + " and " + name2 + " are now partners. Relog to see your new relationship status in your profiles.");
            state default;

        } else {
            llSay(0, name2 + ", you have " + name3 + " as partner already");
            state default;
        }
    }

    touch_start(integer num_detected)    {
        llSetTimerEvent(0.0);
        id2 = llDetectedKey(0);
        name2 = llDetectedName(0);

        if (fakeID) {
            id2 = UUID2;
            name2 = AName2;
        }

        if ((string)id1 == (string)id2)
        {
            llSay(0, "canceled");
            state default;
        }

        // check if new partner has no partnership
        string req = URL +PORT + "/get_partner?PW=" + llEscapeURL(PW) + "&User=" + (string)id2;
        DEBUG(req);
        http_request_id2 = llHTTPRequest(req, PAR, "");
        
    }
}

// dissolve partnership

state dissolve_partnership{
    state_entry()    {
        DEBUG("state dissolve_partnership");
        llSetText(name1 + ", click \nif you want to dissolve\nyour current partnership", <1,1,1>, 1.0);
        llSay(0,name1 + ", click if you want to dissolve your current partnership");
        llSetTimerEvent(TIMEOUT);
    }

    timer()    {
        llSay(0, "Timeout, please try again");
        llSetTimerEvent(0.0);
        state default;
    }

    http_response(key request_id, integer status, list metadata, string body)    {

        if (request_id == http_request_id5) {
            DEBUG("http_request_id5");
            // dissolve: set_partner; 2nd user
            id2 = (key)body;
            string req = URL+PORT  + "/set_partner?PW=" + llEscapeURL(PW) + "&User=" + (string)id2 + "&Partner=" + (string)NULL_KEY;
            DEBUG(req);
            http_request_id6 = llHTTPRequest(req, PAR, "");
        } else if (request_id == http_request_id6) {
            DEBUG("http_request_id6");
            // dissolve: set_partner; 2nd user
            llSay(0, name1 + " and " + name2 + " are not partners anymore");
            state default;
        }
    }
    
    touch_start(integer num_detected)    {
        llSetTimerEvent(0.0);
        id2 = llDetectedKey(0);
        name2 = llDetectedName(0);

        if (fakeID) {
            id2 = UUID2;
            name2 = AName2;
        }


        if ((string)id1 != (string)id2)
        {
            llSay(0, "canceled");
            state default;
        }

        string req = URL +PORT + "/set_partner?PW=" + llEscapeURL(PW) + "&User=" + (string)id1 + "&Partner=" + (string)NULL_KEY;
        DEBUG("state 5, " + req);
        http_request_id5 = llHTTPRequest(req, PAR, "");
        
    }
}
