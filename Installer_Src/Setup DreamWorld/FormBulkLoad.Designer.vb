﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBulkLoad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RegionOwnerTextBox = New System.Windows.Forms.TextBox()
        Me.OwnerLabel = New System.Windows.Forms.Label()
        Me.BulkLoadButton = New System.Windows.Forms.Button()
        Me.CoordX = New System.Windows.Forms.TextBox()
        Me.CoordY = New System.Windows.Forms.TextBox()
        Me.StartingLabel = New System.Windows.Forms.Label()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.YLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.EstateName = New System.Windows.Forms.TextBox()
        Me.Estatenamelabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegionOwnerTextBox
        '
        Me.RegionOwnerTextBox.Location = New System.Drawing.Point(11, 44)
        Me.RegionOwnerTextBox.Name = "RegionOwnerTextBox"
        Me.RegionOwnerTextBox.Size = New System.Drawing.Size(171, 20)
        Me.RegionOwnerTextBox.TabIndex = 1898
        '
        'OwnerLabel
        '
        Me.OwnerLabel.AutoSize = True
        Me.OwnerLabel.Location = New System.Drawing.Point(8, 28)
        Me.OwnerLabel.Name = "OwnerLabel"
        Me.OwnerLabel.Size = New System.Drawing.Size(117, 13)
        Me.OwnerLabel.TabIndex = 1899
        Me.OwnerLabel.Text = "Owner of New Regions"
        '
        'BulkLoadButton
        '
        Me.BulkLoadButton.Image = Global.Outworldz.My.Resources.Resources.package_add
        Me.BulkLoadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BulkLoadButton.Location = New System.Drawing.Point(19, 186)
        Me.BulkLoadButton.Margin = New System.Windows.Forms.Padding(1)
        Me.BulkLoadButton.Name = "BulkLoadButton"
        Me.BulkLoadButton.Size = New System.Drawing.Size(185, 35)
        Me.BulkLoadButton.TabIndex = 1900
        Me.BulkLoadButton.Text = "Bulk Load Regions"
        Me.BulkLoadButton.UseVisualStyleBackColor = True
        '
        'CoordX
        '
        Me.CoordX.Location = New System.Drawing.Point(44, 149)
        Me.CoordX.Name = "CoordX"
        Me.CoordX.Size = New System.Drawing.Size(42, 20)
        Me.CoordX.TabIndex = 1903
        '
        'CoordY
        '
        Me.CoordY.Location = New System.Drawing.Point(125, 149)
        Me.CoordY.Name = "CoordY"
        Me.CoordY.Size = New System.Drawing.Size(42, 20)
        Me.CoordY.TabIndex = 1904
        '
        'StartingLabel
        '
        Me.StartingLabel.AutoSize = True
        Me.StartingLabel.Location = New System.Drawing.Point(27, 133)
        Me.StartingLabel.Name = "StartingLabel"
        Me.StartingLabel.Size = New System.Drawing.Size(87, 13)
        Me.StartingLabel.TabIndex = 1905
        Me.StartingLabel.Text = "Starting Location"
        '
        'XLabel
        '
        Me.XLabel.AutoSize = True
        Me.XLabel.Location = New System.Drawing.Point(27, 152)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Size = New System.Drawing.Size(14, 13)
        Me.XLabel.TabIndex = 1906
        Me.XLabel.Text = "X"
        '
        'YLabel
        '
        Me.YLabel.AutoSize = True
        Me.YLabel.Location = New System.Drawing.Point(105, 152)
        Me.YLabel.Name = "YLabel"
        Me.YLabel.Size = New System.Drawing.Size(14, 13)
        Me.YLabel.TabIndex = 1907
        Me.YLabel.Text = "Y"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Estatenamelabel)
        Me.GroupBox1.Controls.Add(Me.EstateName)
        Me.GroupBox1.Controls.Add(Me.BulkLoadButton)
        Me.GroupBox1.Controls.Add(Me.YLabel)
        Me.GroupBox1.Controls.Add(Me.OwnerLabel)
        Me.GroupBox1.Controls.Add(Me.XLabel)
        Me.GroupBox1.Controls.Add(Me.RegionOwnerTextBox)
        Me.GroupBox1.Controls.Add(Me.StartingLabel)
        Me.GroupBox1.Controls.Add(Me.CoordX)
        Me.GroupBox1.Controls.Add(Me.CoordY)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 234)
        Me.GroupBox1.TabIndex = 1908
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load All Free Regions"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(241, 25)
        Me.ToolStrip1.TabIndex = 1909
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = Global.Outworldz.My.Resources.Resources.about
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 22)
        Me.ToolStripLabel1.Text = "Help"
        '
        'EstateName
        '
        Me.EstateName.Location = New System.Drawing.Point(11, 95)
        Me.EstateName.Name = "EstateName"
        Me.EstateName.Size = New System.Drawing.Size(171, 20)
        Me.EstateName.TabIndex = 1908
        '
        'Estatenamelabel
        '
        Me.Estatenamelabel.AutoSize = True
        Me.Estatenamelabel.Location = New System.Drawing.Point(8, 79)
        Me.Estatenamelabel.Name = "Estatenamelabel"
        Me.Estatenamelabel.Size = New System.Drawing.Size(37, 13)
        Me.Estatenamelabel.TabIndex = 1909
        Me.Estatenamelabel.Text = "Estate"
        '
        'FormBulkLoad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 285)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormBulkLoad"
        Me.Text = "FormBulkLoad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RegionOwnerTextBox As TextBox
    Friend WithEvents OwnerLabel As Label
    Friend WithEvents BulkLoadButton As Button
    Friend WithEvents CoordX As TextBox
    Friend WithEvents CoordY As TextBox
    Friend WithEvents StartingLabel As Label
    Friend WithEvents XLabel As Label
    Friend WithEvents YLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Estatenamelabel As Label
    Friend WithEvents EstateName As TextBox
End Class
