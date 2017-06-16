<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHelp))
        Me.pnlHelpTitle = New System.Windows.Forms.Panel()
        Me.btnCloseInfo = New System.Windows.Forms.Button()
        Me.lblHelpTitle = New System.Windows.Forms.Label()
        Me.tbcHelp = New System.Windows.Forms.TabControl()
        Me.tabAbout = New System.Windows.Forms.TabPage()
        Me.tabSetup = New System.Windows.Forms.TabPage()
        Me.tabGamePlay = New System.Windows.Forms.TabPage()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblHelpSetup1 = New System.Windows.Forms.Label()
        Me.lblHelpSetup2 = New System.Windows.Forms.Label()
        Me.lblHelpSetup3 = New System.Windows.Forms.Label()
        Me.lblHelpSetup4 = New System.Windows.Forms.Label()
        Me.lblHelpTestMode = New System.Windows.Forms.Label()
        Me.lblHelpImages = New System.Windows.Forms.Label()
        Me.lblHelpPlanet = New System.Windows.Forms.Label()
        Me.lblGamePlay1 = New System.Windows.Forms.Label()
        Me.lblGamePlay2 = New System.Windows.Forms.Label()
        Me.labelGamePlay3 = New System.Windows.Forms.Label()
        Me.lblGamePlay4 = New System.Windows.Forms.Label()
        Me.lblHelpCoordFiring = New System.Windows.Forms.Label()
        Me.lblHelpClickFiring = New System.Windows.Forms.Label()
        Me.lblHelpEndGame = New System.Windows.Forms.Label()
        Me.pnlHelpTitle.SuspendLayout()
        Me.tbcHelp.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.tabSetup.SuspendLayout()
        Me.tabGamePlay.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHelpTitle
        '
        Me.pnlHelpTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHelpTitle.Controls.Add(Me.lblHelpTitle)
        Me.pnlHelpTitle.Location = New System.Drawing.Point(12, 12)
        Me.pnlHelpTitle.Name = "pnlHelpTitle"
        Me.pnlHelpTitle.Size = New System.Drawing.Size(413, 57)
        Me.pnlHelpTitle.TabIndex = 0
        '
        'btnCloseInfo
        '
        Me.btnCloseInfo.BackColor = System.Drawing.Color.Black
        Me.btnCloseInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseInfo.ForeColor = System.Drawing.Color.White
        Me.btnCloseInfo.Location = New System.Drawing.Point(432, 13)
        Me.btnCloseInfo.Name = "btnCloseInfo"
        Me.btnCloseInfo.Size = New System.Drawing.Size(71, 55)
        Me.btnCloseInfo.TabIndex = 1
        Me.btnCloseInfo.Text = "Close"
        Me.btnCloseInfo.UseVisualStyleBackColor = False
        '
        'lblHelpTitle
        '
        Me.lblHelpTitle.AutoSize = True
        Me.lblHelpTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblHelpTitle.Location = New System.Drawing.Point(15, 10)
        Me.lblHelpTitle.Name = "lblHelpTitle"
        Me.lblHelpTitle.Size = New System.Drawing.Size(381, 33)
        Me.lblHelpTitle.TabIndex = 0
        Me.lblHelpTitle.Text = "Battle Deathstar Instructions"
        '
        'tbcHelp
        '
        Me.tbcHelp.Controls.Add(Me.tabAbout)
        Me.tbcHelp.Controls.Add(Me.tabSetup)
        Me.tbcHelp.Controls.Add(Me.tabGamePlay)
        Me.tbcHelp.Location = New System.Drawing.Point(17, 107)
        Me.tbcHelp.Name = "tbcHelp"
        Me.tbcHelp.SelectedIndex = 0
        Me.tbcHelp.Size = New System.Drawing.Size(476, 414)
        Me.tbcHelp.TabIndex = 2
        '
        'tabAbout
        '
        Me.tabAbout.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BattleDeathstar
        Me.tabAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabAbout.Controls.Add(Me.lblAbout)
        Me.tabAbout.Location = New System.Drawing.Point(4, 22)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAbout.Size = New System.Drawing.Size(468, 388)
        Me.tabAbout.TabIndex = 0
        Me.tabAbout.Text = "About Battle Deathstar"
        Me.tabAbout.UseVisualStyleBackColor = True
        '
        'tabSetup
        '
        Me.tabSetup.BackColor = System.Drawing.Color.Black
        Me.tabSetup.Controls.Add(Me.lblHelpPlanet)
        Me.tabSetup.Controls.Add(Me.lblHelpImages)
        Me.tabSetup.Controls.Add(Me.lblHelpTestMode)
        Me.tabSetup.Controls.Add(Me.lblHelpSetup4)
        Me.tabSetup.Controls.Add(Me.lblHelpSetup3)
        Me.tabSetup.Controls.Add(Me.lblHelpSetup2)
        Me.tabSetup.Controls.Add(Me.lblHelpSetup1)
        Me.tabSetup.Location = New System.Drawing.Point(4, 22)
        Me.tabSetup.Name = "tabSetup"
        Me.tabSetup.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSetup.Size = New System.Drawing.Size(468, 388)
        Me.tabSetup.TabIndex = 1
        Me.tabSetup.Text = "Setup"
        '
        'tabGamePlay
        '
        Me.tabGamePlay.BackColor = System.Drawing.Color.Black
        Me.tabGamePlay.Controls.Add(Me.lblHelpEndGame)
        Me.tabGamePlay.Controls.Add(Me.lblHelpClickFiring)
        Me.tabGamePlay.Controls.Add(Me.lblHelpCoordFiring)
        Me.tabGamePlay.Controls.Add(Me.lblGamePlay4)
        Me.tabGamePlay.Controls.Add(Me.labelGamePlay3)
        Me.tabGamePlay.Controls.Add(Me.lblGamePlay2)
        Me.tabGamePlay.Controls.Add(Me.lblGamePlay1)
        Me.tabGamePlay.Location = New System.Drawing.Point(4, 22)
        Me.tabGamePlay.Name = "tabGamePlay"
        Me.tabGamePlay.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGamePlay.Size = New System.Drawing.Size(468, 388)
        Me.tabGamePlay.TabIndex = 2
        Me.tabGamePlay.Text = "Game Play"
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.Color.White
        Me.lblAbout.Location = New System.Drawing.Point(14, 17)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(224, 260)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = resources.GetString("lblAbout.Text")
        '
        'lblHelpSetup1
        '
        Me.lblHelpSetup1.AutoSize = True
        Me.lblHelpSetup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpSetup1.ForeColor = System.Drawing.Color.White
        Me.lblHelpSetup1.Location = New System.Drawing.Point(18, 12)
        Me.lblHelpSetup1.Name = "lblHelpSetup1"
        Me.lblHelpSetup1.Size = New System.Drawing.Size(371, 112)
        Me.lblHelpSetup1.TabIndex = 0
        Me.lblHelpSetup1.Text = resources.GetString("lblHelpSetup1.Text")
        '
        'lblHelpSetup2
        '
        Me.lblHelpSetup2.AutoSize = True
        Me.lblHelpSetup2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpSetup2.ForeColor = System.Drawing.Color.White
        Me.lblHelpSetup2.Location = New System.Drawing.Point(104, 146)
        Me.lblHelpSetup2.Name = "lblHelpSetup2"
        Me.lblHelpSetup2.Size = New System.Drawing.Size(331, 48)
        Me.lblHelpSetup2.TabIndex = 1
        Me.lblHelpSetup2.Text = "This allows the user to view the data stored in the array" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " and view where planet" &
    "s are placed during game play. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "They are visible during the setup anyways."
        '
        'lblHelpSetup3
        '
        Me.lblHelpSetup3.AutoSize = True
        Me.lblHelpSetup3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpSetup3.ForeColor = System.Drawing.Color.White
        Me.lblHelpSetup3.Location = New System.Drawing.Point(104, 207)
        Me.lblHelpSetup3.Name = "lblHelpSetup3"
        Me.lblHelpSetup3.Size = New System.Drawing.Size(360, 48)
        Me.lblHelpSetup3.TabIndex = 2
        Me.lblHelpSetup3.Text = "This is an advanced feature (i.e. bonus question) that allows" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " the user to play " &
    "the game with some simple graphics rather" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " than just numbers and colours."
        '
        'lblHelpSetup4
        '
        Me.lblHelpSetup4.AutoSize = True
        Me.lblHelpSetup4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpSetup4.ForeColor = System.Drawing.Color.White
        Me.lblHelpSetup4.Location = New System.Drawing.Point(104, 266)
        Me.lblHelpSetup4.Name = "lblHelpSetup4"
        Me.lblHelpSetup4.Size = New System.Drawing.Size(333, 64)
        Me.lblHelpSetup4.TabIndex = 3
        Me.lblHelpSetup4.Text = "There are three ways to place the planets in the galaxy." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1) Clicking the grid." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "2) Using the coordinates and place planets button." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3) Generating random planets" &
    "."
        '
        'lblHelpTestMode
        '
        Me.lblHelpTestMode.AutoSize = True
        Me.lblHelpTestMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpTestMode.ForeColor = System.Drawing.Color.Gold
        Me.lblHelpTestMode.Location = New System.Drawing.Point(2, 147)
        Me.lblHelpTestMode.Name = "lblHelpTestMode"
        Me.lblHelpTestMode.Size = New System.Drawing.Size(93, 20)
        Me.lblHelpTestMode.TabIndex = 4
        Me.lblHelpTestMode.Text = "Test Mode"
        '
        'lblHelpImages
        '
        Me.lblHelpImages.AutoSize = True
        Me.lblHelpImages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpImages.ForeColor = System.Drawing.Color.Gold
        Me.lblHelpImages.Location = New System.Drawing.Point(2, 205)
        Me.lblHelpImages.Name = "lblHelpImages"
        Me.lblHelpImages.Size = New System.Drawing.Size(105, 20)
        Me.lblHelpImages.TabIndex = 5
        Me.lblHelpImages.Text = "Use Images"
        '
        'lblHelpPlanet
        '
        Me.lblHelpPlanet.AutoSize = True
        Me.lblHelpPlanet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpPlanet.ForeColor = System.Drawing.Color.Gold
        Me.lblHelpPlanet.Location = New System.Drawing.Point(2, 264)
        Me.lblHelpPlanet.Name = "lblHelpPlanet"
        Me.lblHelpPlanet.Size = New System.Drawing.Size(69, 20)
        Me.lblHelpPlanet.TabIndex = 6
        Me.lblHelpPlanet.Text = "Planets"
        '
        'lblGamePlay1
        '
        Me.lblGamePlay1.AutoSize = True
        Me.lblGamePlay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamePlay1.ForeColor = System.Drawing.Color.White
        Me.lblGamePlay1.Location = New System.Drawing.Point(6, 21)
        Me.lblGamePlay1.Name = "lblGamePlay1"
        Me.lblGamePlay1.Size = New System.Drawing.Size(452, 48)
        Me.lblGamePlay1.TabIndex = 1
        Me.lblGamePlay1.Text = "To play the game, you simply take shots within the Galaxy Grid and destroy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " all " &
    "the resistance planets before you completely drain the energy of the sun" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " and c" &
    "an no longer fire the weapon." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblGamePlay2
        '
        Me.lblGamePlay2.AutoSize = True
        Me.lblGamePlay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamePlay2.ForeColor = System.Drawing.Color.White
        Me.lblGamePlay2.Location = New System.Drawing.Point(119, 94)
        Me.lblGamePlay2.Name = "lblGamePlay2"
        Me.lblGamePlay2.Size = New System.Drawing.Size(320, 48)
        Me.lblGamePlay2.TabIndex = 2
        Me.lblGamePlay2.Text = "You can set the X and Y coordinates and click the fire" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " button. This will  fire " &
    "the weapon and if a planet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " exists in that grid, it will be destroyed"
        '
        'labelGamePlay3
        '
        Me.labelGamePlay3.AutoSize = True
        Me.labelGamePlay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelGamePlay3.ForeColor = System.Drawing.Color.White
        Me.labelGamePlay3.Location = New System.Drawing.Point(119, 165)
        Me.labelGamePlay3.Name = "labelGamePlay3"
        Me.labelGamePlay3.Size = New System.Drawing.Size(346, 48)
        Me.labelGamePlay3.TabIndex = 3
        Me.labelGamePlay3.Text = "Alternatively, you can click on the grid in which you wish to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " fire the weapon. " &
    "It will be fired immediately upon clicking." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " If a planet exists, it will be des" &
    "troyed."
        '
        'lblGamePlay4
        '
        Me.lblGamePlay4.AutoSize = True
        Me.lblGamePlay4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamePlay4.ForeColor = System.Drawing.Color.White
        Me.lblGamePlay4.Location = New System.Drawing.Point(119, 245)
        Me.lblGamePlay4.Name = "lblGamePlay4"
        Me.lblGamePlay4.Size = New System.Drawing.Size(223, 112)
        Me.lblGamePlay4.TabIndex = 4
        Me.lblGamePlay4.Text = "There are 3 ways to end the game:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1) Reset Button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2) Destroying all planets." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3) Failure to destroy all planets in the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "allotted number of shots."
        '
        'lblHelpCoordFiring
        '
        Me.lblHelpCoordFiring.AutoSize = True
        Me.lblHelpCoordFiring.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpCoordFiring.ForeColor = System.Drawing.Color.Gold
        Me.lblHelpCoordFiring.Location = New System.Drawing.Point(3, 94)
        Me.lblHelpCoordFiring.Name = "lblHelpCoordFiring"
        Me.lblHelpCoordFiring.Size = New System.Drawing.Size(107, 20)
        Me.lblHelpCoordFiring.TabIndex = 5
        Me.lblHelpCoordFiring.Text = "Coord Firing"
        '
        'lblHelpClickFiring
        '
        Me.lblHelpClickFiring.AutoSize = True
        Me.lblHelpClickFiring.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpClickFiring.ForeColor = System.Drawing.Color.Gold
        Me.lblHelpClickFiring.Location = New System.Drawing.Point(3, 162)
        Me.lblHelpClickFiring.Name = "lblHelpClickFiring"
        Me.lblHelpClickFiring.Size = New System.Drawing.Size(97, 20)
        Me.lblHelpClickFiring.TabIndex = 6
        Me.lblHelpClickFiring.Text = "Click Firing"
        '
        'lblHelpEndGame
        '
        Me.lblHelpEndGame.AutoSize = True
        Me.lblHelpEndGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpEndGame.ForeColor = System.Drawing.Color.Gold
        Me.lblHelpEndGame.Location = New System.Drawing.Point(3, 242)
        Me.lblHelpEndGame.Name = "lblHelpEndGame"
        Me.lblHelpEndGame.Size = New System.Drawing.Size(94, 20)
        Me.lblHelpEndGame.TabIndex = 7
        Me.lblHelpEndGame.Text = "End Game"
        '
        'frmHelp
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(513, 546)
        Me.Controls.Add(Me.tbcHelp)
        Me.Controls.Add(Me.btnCloseInfo)
        Me.Controls.Add(Me.pnlHelpTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmHelp"
        Me.pnlHelpTitle.ResumeLayout(False)
        Me.pnlHelpTitle.PerformLayout()
        Me.tbcHelp.ResumeLayout(False)
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        Me.tabSetup.ResumeLayout(False)
        Me.tabSetup.PerformLayout()
        Me.tabGamePlay.ResumeLayout(False)
        Me.tabGamePlay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHelpTitle As Panel
    Friend WithEvents lblHelpTitle As Label
    Friend WithEvents btnCloseInfo As Button
    Friend WithEvents tbcHelp As TabControl
    Friend WithEvents tabAbout As TabPage
    Friend WithEvents tabSetup As TabPage
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblHelpSetup4 As Label
    Friend WithEvents lblHelpSetup3 As Label
    Friend WithEvents lblHelpSetup2 As Label
    Friend WithEvents lblHelpSetup1 As Label
    Friend WithEvents tabGamePlay As TabPage
    Friend WithEvents lblHelpPlanet As Label
    Friend WithEvents lblHelpImages As Label
    Friend WithEvents lblHelpTestMode As Label
    Friend WithEvents lblHelpEndGame As Label
    Friend WithEvents lblHelpClickFiring As Label
    Friend WithEvents lblHelpCoordFiring As Label
    Friend WithEvents lblGamePlay4 As Label
    Friend WithEvents labelGamePlay3 As Label
    Friend WithEvents lblGamePlay2 As Label
    Friend WithEvents lblGamePlay1 As Label
End Class
