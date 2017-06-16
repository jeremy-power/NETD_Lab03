<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeathStarForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeathStarForm1))
        Me.dgvBattlefield = New System.Windows.Forms.DataGridView()
        Me.gbxSetup = New System.Windows.Forms.GroupBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnAddPlanet = New System.Windows.Forms.Button()
        Me.btnRandomPlanets = New System.Windows.Forms.Button()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblManualSetup = New System.Windows.Forms.Label()
        Me.lblPlanetNum = New System.Windows.Forms.Label()
        Me.lblMaxShots = New System.Windows.Forms.Label()
        Me.cbxImages = New System.Windows.Forms.CheckBox()
        Me.cbxTestMode = New System.Windows.Forms.CheckBox()
        Me.nudYCoord = New System.Windows.Forms.NumericUpDown()
        Me.nudXCoord = New System.Windows.Forms.NumericUpDown()
        Me.nudPlanetNum = New System.Windows.Forms.NumericUpDown()
        Me.nudMaxShots = New System.Windows.Forms.NumericUpDown()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.gbxPlayMode = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblComplete = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDestroyed = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblShotsTaken = New System.Windows.Forms.Label()
        Me.lblOf = New System.Windows.Forms.Label()
        Me.lblCompleteInfo = New System.Windows.Forms.Label()
        Me.lblDestroyedInfo = New System.Windows.Forms.Label()
        Me.lblShotsTakenInfo = New System.Windows.Forms.Label()
        Me.lblYPlay = New System.Windows.Forms.Label()
        Me.lblXPlay = New System.Windows.Forms.Label()
        Me.nudPlayY = New System.Windows.Forms.NumericUpDown()
        Me.nudPlayX = New System.Windows.Forms.NumericUpDown()
        Me.pbxFire = New System.Windows.Forms.PictureBox()
        Me.pbxHelp = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cbxSound = New System.Windows.Forms.CheckBox()
        CType(Me.dgvBattlefield, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSetup.SuspendLayout()
        CType(Me.nudYCoord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXCoord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlanetNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxShots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        Me.gbxPlayMode.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.nudPlayY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlayX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBattlefield
        '
        Me.dgvBattlefield.AllowUserToAddRows = False
        Me.dgvBattlefield.AllowUserToDeleteRows = False
        Me.dgvBattlefield.AllowUserToResizeColumns = False
        Me.dgvBattlefield.AllowUserToResizeRows = False
        Me.dgvBattlefield.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvBattlefield.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBattlefield.Location = New System.Drawing.Point(14, 277)
        Me.dgvBattlefield.MultiSelect = False
        Me.dgvBattlefield.Name = "dgvBattlefield"
        Me.dgvBattlefield.ReadOnly = True
        Me.dgvBattlefield.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvBattlefield.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvBattlefield.Size = New System.Drawing.Size(484, 383)
        Me.dgvBattlefield.TabIndex = 0
        '
        'gbxSetup
        '
        Me.gbxSetup.BackColor = System.Drawing.Color.Transparent
        Me.gbxSetup.Controls.Add(Me.btnPlay)
        Me.gbxSetup.Controls.Add(Me.btnAddPlanet)
        Me.gbxSetup.Controls.Add(Me.btnRandomPlanets)
        Me.gbxSetup.Controls.Add(Me.lblY)
        Me.gbxSetup.Controls.Add(Me.lblX)
        Me.gbxSetup.Controls.Add(Me.lblManualSetup)
        Me.gbxSetup.Controls.Add(Me.lblPlanetNum)
        Me.gbxSetup.Controls.Add(Me.lblMaxShots)
        Me.gbxSetup.Controls.Add(Me.cbxImages)
        Me.gbxSetup.Controls.Add(Me.cbxTestMode)
        Me.gbxSetup.Controls.Add(Me.nudYCoord)
        Me.gbxSetup.Controls.Add(Me.nudXCoord)
        Me.gbxSetup.Controls.Add(Me.nudPlanetNum)
        Me.gbxSetup.Controls.Add(Me.nudMaxShots)
        Me.gbxSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSetup.ForeColor = System.Drawing.Color.White
        Me.gbxSetup.Location = New System.Drawing.Point(14, 69)
        Me.gbxSetup.Name = "gbxSetup"
        Me.gbxSetup.Size = New System.Drawing.Size(530, 202)
        Me.gbxSetup.TabIndex = 1
        Me.gbxSetup.TabStop = False
        Me.gbxSetup.Text = "Game Setup"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Black
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(432, 156)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(92, 40)
        Me.btnPlay.TabIndex = 13
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnAddPlanet
        '
        Me.btnAddPlanet.BackColor = System.Drawing.Color.Black
        Me.btnAddPlanet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlanet.Location = New System.Drawing.Point(258, 156)
        Me.btnAddPlanet.Name = "btnAddPlanet"
        Me.btnAddPlanet.Size = New System.Drawing.Size(151, 40)
        Me.btnAddPlanet.TabIndex = 12
        Me.btnAddPlanet.Text = "Add Planet"
        Me.btnAddPlanet.UseVisualStyleBackColor = False
        '
        'btnRandomPlanets
        '
        Me.btnRandomPlanets.BackColor = System.Drawing.Color.Black
        Me.btnRandomPlanets.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRandomPlanets.Location = New System.Drawing.Point(213, 21)
        Me.btnRandomPlanets.Name = "btnRandomPlanets"
        Me.btnRandomPlanets.Size = New System.Drawing.Size(181, 62)
        Me.btnRandomPlanets.TabIndex = 11
        Me.btnRandomPlanets.Text = "Choose Random" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Placements" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnRandomPlanets.UseVisualStyleBackColor = False
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.ForeColor = System.Drawing.Color.Gold
        Me.lblY.Location = New System.Drawing.Point(326, 115)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(32, 31)
        Me.lblY.TabIndex = 10
        Me.lblY.Text = "Y"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.ForeColor = System.Drawing.Color.Gold
        Me.lblX.Location = New System.Drawing.Point(207, 115)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(32, 31)
        Me.lblX.TabIndex = 9
        Me.lblX.Text = "X"
        '
        'lblManualSetup
        '
        Me.lblManualSetup.AutoSize = True
        Me.lblManualSetup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManualSetup.Location = New System.Drawing.Point(212, 86)
        Me.lblManualSetup.Name = "lblManualSetup"
        Me.lblManualSetup.Size = New System.Drawing.Size(210, 20)
        Me.lblManualSetup.TabIndex = 8
        Me.lblManualSetup.Text = "Manually Setup New Planets"
        '
        'lblPlanetNum
        '
        Me.lblPlanetNum.AutoSize = True
        Me.lblPlanetNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanetNum.Location = New System.Drawing.Point(10, 89)
        Me.lblPlanetNum.Name = "lblPlanetNum"
        Me.lblPlanetNum.Size = New System.Drawing.Size(75, 20)
        Me.lblPlanetNum.TabIndex = 7
        Me.lblPlanetNum.Text = "# Planets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblPlanetNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaxShots
        '
        Me.lblMaxShots.AutoSize = True
        Me.lblMaxShots.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxShots.Location = New System.Drawing.Point(7, 37)
        Me.lblMaxShots.Name = "lblMaxShots"
        Me.lblMaxShots.Size = New System.Drawing.Size(84, 40)
        Me.lblMaxShots.TabIndex = 6
        Me.lblMaxShots.Text = "Max Shots" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Allowed"
        Me.lblMaxShots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxImages
        '
        Me.cbxImages.AutoSize = True
        Me.cbxImages.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxImages.Location = New System.Drawing.Point(7, 155)
        Me.cbxImages.Name = "cbxImages"
        Me.cbxImages.Size = New System.Drawing.Size(114, 24)
        Me.cbxImages.TabIndex = 5
        Me.cbxImages.Text = "Use Images"
        Me.cbxImages.UseVisualStyleBackColor = True
        '
        'cbxTestMode
        '
        Me.cbxTestMode.AutoSize = True
        Me.cbxTestMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTestMode.Location = New System.Drawing.Point(7, 132)
        Me.cbxTestMode.Name = "cbxTestMode"
        Me.cbxTestMode.Size = New System.Drawing.Size(103, 24)
        Me.cbxTestMode.TabIndex = 4
        Me.cbxTestMode.Text = "Test Mode"
        Me.cbxTestMode.UseVisualStyleBackColor = True
        '
        'nudYCoord
        '
        Me.nudYCoord.Location = New System.Drawing.Point(364, 112)
        Me.nudYCoord.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudYCoord.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudYCoord.Name = "nudYCoord"
        Me.nudYCoord.ReadOnly = True
        Me.nudYCoord.Size = New System.Drawing.Size(59, 38)
        Me.nudYCoord.TabIndex = 3
        Me.nudYCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudYCoord.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudXCoord
        '
        Me.nudXCoord.Location = New System.Drawing.Point(245, 112)
        Me.nudXCoord.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudXCoord.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudXCoord.Name = "nudXCoord"
        Me.nudXCoord.Size = New System.Drawing.Size(59, 38)
        Me.nudXCoord.TabIndex = 2
        Me.nudXCoord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudXCoord.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPlanetNum
        '
        Me.nudPlanetNum.BackColor = System.Drawing.Color.Black
        Me.nudPlanetNum.ForeColor = System.Drawing.Color.White
        Me.nudPlanetNum.Location = New System.Drawing.Point(97, 81)
        Me.nudPlanetNum.Maximum = New Decimal(New Integer() {225, 0, 0, 0})
        Me.nudPlanetNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPlanetNum.Name = "nudPlanetNum"
        Me.nudPlanetNum.Size = New System.Drawing.Size(64, 38)
        Me.nudPlanetNum.TabIndex = 1
        Me.nudPlanetNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPlanetNum.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'nudMaxShots
        '
        Me.nudMaxShots.BackColor = System.Drawing.Color.Black
        Me.nudMaxShots.ForeColor = System.Drawing.Color.White
        Me.nudMaxShots.Location = New System.Drawing.Point(97, 37)
        Me.nudMaxShots.Maximum = New Decimal(New Integer() {225, 0, 0, 0})
        Me.nudMaxShots.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMaxShots.Name = "nudMaxShots"
        Me.nudMaxShots.Size = New System.Drawing.Size(64, 38)
        Me.nudMaxShots.TabIndex = 0
        Me.nudMaxShots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudMaxShots.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Black
        Me.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Location = New System.Drawing.Point(11, 8)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(614, 52)
        Me.pnlTitle.TabIndex = 2
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(158, 1)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(266, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Battle Deathstar"
        '
        'gbxPlayMode
        '
        Me.gbxPlayMode.BackColor = System.Drawing.Color.Transparent
        Me.gbxPlayMode.Controls.Add(Me.Panel3)
        Me.gbxPlayMode.Controls.Add(Me.Panel2)
        Me.gbxPlayMode.Controls.Add(Me.Panel1)
        Me.gbxPlayMode.Controls.Add(Me.lblOf)
        Me.gbxPlayMode.Controls.Add(Me.lblCompleteInfo)
        Me.gbxPlayMode.Controls.Add(Me.lblDestroyedInfo)
        Me.gbxPlayMode.Controls.Add(Me.lblShotsTakenInfo)
        Me.gbxPlayMode.Controls.Add(Me.lblYPlay)
        Me.gbxPlayMode.Controls.Add(Me.lblXPlay)
        Me.gbxPlayMode.Controls.Add(Me.nudPlayY)
        Me.gbxPlayMode.Controls.Add(Me.nudPlayX)
        Me.gbxPlayMode.Controls.Add(Me.pbxFire)
        Me.gbxPlayMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPlayMode.ForeColor = System.Drawing.Color.White
        Me.gbxPlayMode.Location = New System.Drawing.Point(547, 312)
        Me.gbxPlayMode.Name = "gbxPlayMode"
        Me.gbxPlayMode.Size = New System.Drawing.Size(530, 202)
        Me.gbxPlayMode.TabIndex = 3
        Me.gbxPlayMode.TabStop = False
        Me.gbxPlayMode.Text = "Play Mode"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.lblComplete)
        Me.Panel3.Location = New System.Drawing.Point(351, 135)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 39)
        Me.Panel3.TabIndex = 21
        '
        'lblComplete
        '
        Me.lblComplete.AutoSize = True
        Me.lblComplete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblComplete.Location = New System.Drawing.Point(0, 0)
        Me.lblComplete.Name = "lblComplete"
        Me.lblComplete.Size = New System.Drawing.Size(29, 31)
        Me.lblComplete.TabIndex = 0
        Me.lblComplete.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lblDestroyed)
        Me.Panel2.Location = New System.Drawing.Point(351, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(70, 39)
        Me.Panel2.TabIndex = 20
        '
        'lblDestroyed
        '
        Me.lblDestroyed.AutoSize = True
        Me.lblDestroyed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDestroyed.Location = New System.Drawing.Point(0, 0)
        Me.lblDestroyed.Name = "lblDestroyed"
        Me.lblDestroyed.Size = New System.Drawing.Size(29, 31)
        Me.lblDestroyed.TabIndex = 0
        Me.lblDestroyed.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblShotsTaken)
        Me.Panel1.Location = New System.Drawing.Point(351, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(70, 39)
        Me.Panel1.TabIndex = 19
        '
        'lblShotsTaken
        '
        Me.lblShotsTaken.AutoSize = True
        Me.lblShotsTaken.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblShotsTaken.Location = New System.Drawing.Point(0, 0)
        Me.lblShotsTaken.Name = "lblShotsTaken"
        Me.lblShotsTaken.Size = New System.Drawing.Size(29, 31)
        Me.lblShotsTaken.TabIndex = 0
        Me.lblShotsTaken.Text = "0"
        Me.lblShotsTaken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOf
        '
        Me.lblOf.AutoSize = True
        Me.lblOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOf.Location = New System.Drawing.Point(434, 49)
        Me.lblOf.Name = "lblOf"
        Me.lblOf.Size = New System.Drawing.Size(25, 20)
        Me.lblOf.TabIndex = 18
        Me.lblOf.Text = "of"
        '
        'lblCompleteInfo
        '
        Me.lblCompleteInfo.AutoSize = True
        Me.lblCompleteInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompleteInfo.Location = New System.Drawing.Point(228, 147)
        Me.lblCompleteInfo.Name = "lblCompleteInfo"
        Me.lblCompleteInfo.Size = New System.Drawing.Size(105, 20)
        Me.lblCompleteInfo.TabIndex = 17
        Me.lblCompleteInfo.Text = "% Complete"
        '
        'lblDestroyedInfo
        '
        Me.lblDestroyedInfo.AutoSize = True
        Me.lblDestroyedInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDestroyedInfo.Location = New System.Drawing.Point(228, 102)
        Me.lblDestroyedInfo.Name = "lblDestroyedInfo"
        Me.lblDestroyedInfo.Size = New System.Drawing.Size(91, 20)
        Me.lblDestroyedInfo.TabIndex = 16
        Me.lblDestroyedInfo.Text = "Destroyed"
        '
        'lblShotsTakenInfo
        '
        Me.lblShotsTakenInfo.AutoSize = True
        Me.lblShotsTakenInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShotsTakenInfo.Location = New System.Drawing.Point(228, 51)
        Me.lblShotsTakenInfo.Name = "lblShotsTakenInfo"
        Me.lblShotsTakenInfo.Size = New System.Drawing.Size(110, 20)
        Me.lblShotsTakenInfo.TabIndex = 15
        Me.lblShotsTakenInfo.Text = "Shots Taken"
        '
        'lblYPlay
        '
        Me.lblYPlay.AutoSize = True
        Me.lblYPlay.ForeColor = System.Drawing.Color.Gold
        Me.lblYPlay.Location = New System.Drawing.Point(125, 49)
        Me.lblYPlay.Name = "lblYPlay"
        Me.lblYPlay.Size = New System.Drawing.Size(32, 31)
        Me.lblYPlay.TabIndex = 14
        Me.lblYPlay.Text = "Y"
        '
        'lblXPlay
        '
        Me.lblXPlay.AutoSize = True
        Me.lblXPlay.ForeColor = System.Drawing.Color.Gold
        Me.lblXPlay.Location = New System.Drawing.Point(6, 49)
        Me.lblXPlay.Name = "lblXPlay"
        Me.lblXPlay.Size = New System.Drawing.Size(32, 31)
        Me.lblXPlay.TabIndex = 13
        Me.lblXPlay.Text = "X"
        '
        'nudPlayY
        '
        Me.nudPlayY.Location = New System.Drawing.Point(163, 46)
        Me.nudPlayY.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudPlayY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPlayY.Name = "nudPlayY"
        Me.nudPlayY.ReadOnly = True
        Me.nudPlayY.Size = New System.Drawing.Size(59, 38)
        Me.nudPlayY.TabIndex = 12
        Me.nudPlayY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPlayY.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPlayX
        '
        Me.nudPlayX.Location = New System.Drawing.Point(44, 46)
        Me.nudPlayX.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        Me.nudPlayX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPlayX.Name = "nudPlayX"
        Me.nudPlayX.Size = New System.Drawing.Size(59, 38)
        Me.nudPlayX.TabIndex = 11
        Me.nudPlayX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudPlayX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pbxFire
        '
        Me.pbxFire.Image = Global.WindowsApplication1.My.Resources.Resources.Fire1
        Me.pbxFire.Location = New System.Drawing.Point(77, 90)
        Me.pbxFire.Name = "pbxFire"
        Me.pbxFire.Size = New System.Drawing.Size(97, 96)
        Me.pbxFire.TabIndex = 0
        Me.pbxFire.TabStop = False
        '
        'pbxHelp
        '
        Me.pbxHelp.BackColor = System.Drawing.Color.Transparent
        Me.pbxHelp.Image = Global.WindowsApplication1.My.Resources.Resources.help48
        Me.pbxHelp.Location = New System.Drawing.Point(566, 184)
        Me.pbxHelp.Name = "pbxHelp"
        Me.pbxHelp.Size = New System.Drawing.Size(45, 46)
        Me.pbxHelp.TabIndex = 4
        Me.pbxHelp.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(550, 90)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 40)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Black
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(550, 136)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(78, 40)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'cbxSound
        '
        Me.cbxSound.AutoSize = True
        Me.cbxSound.BackColor = System.Drawing.Color.Transparent
        Me.cbxSound.ForeColor = System.Drawing.Color.White
        Me.cbxSound.Location = New System.Drawing.Point(504, 585)
        Me.cbxSound.Name = "cbxSound"
        Me.cbxSound.Size = New System.Drawing.Size(57, 17)
        Me.cbxSound.TabIndex = 16
        Me.cbxSound.Text = "Sound"
        Me.cbxSound.UseVisualStyleBackColor = False
        '
        'DeathStarForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BattleDeathstar
        Me.ClientSize = New System.Drawing.Size(1093, 666)
        Me.Controls.Add(Me.cbxSound)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pbxHelp)
        Me.Controls.Add(Me.gbxPlayMode)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.gbxSetup)
        Me.Controls.Add(Me.dgvBattlefield)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeathStarForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deathstar Wars"
        CType(Me.dgvBattlefield, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxSetup.ResumeLayout(False)
        Me.gbxSetup.PerformLayout()
        CType(Me.nudYCoord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudXCoord, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlanetNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxShots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitle.ResumeLayout(False)
        Me.pnlTitle.PerformLayout()
        Me.gbxPlayMode.ResumeLayout(False)
        Me.gbxPlayMode.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.nudPlayY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPlayX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBattlefield As DataGridView
    Friend WithEvents gbxSetup As GroupBox
    Friend WithEvents lblY As Label
    Friend WithEvents lblX As Label
    Friend WithEvents lblManualSetup As Label
    Friend WithEvents lblPlanetNum As Label
    Friend WithEvents lblMaxShots As Label
    Friend WithEvents cbxImages As CheckBox
    Friend WithEvents cbxTestMode As CheckBox
    Friend WithEvents nudYCoord As NumericUpDown
    Friend WithEvents nudXCoord As NumericUpDown
    Friend WithEvents nudPlanetNum As NumericUpDown
    Friend WithEvents nudMaxShots As NumericUpDown
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents gbxPlayMode As GroupBox
    Friend WithEvents pbxHelp As PictureBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnAddPlanet As Button
    Friend WithEvents btnRandomPlanets As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblShotsTaken As Label
    Friend WithEvents lblOf As Label
    Friend WithEvents lblCompleteInfo As Label
    Friend WithEvents lblDestroyedInfo As Label
    Friend WithEvents lblShotsTakenInfo As Label
    Friend WithEvents lblYPlay As Label
    Friend WithEvents lblXPlay As Label
    Friend WithEvents nudPlayY As NumericUpDown
    Friend WithEvents nudPlayX As NumericUpDown
    Friend WithEvents pbxFire As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblComplete As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDestroyed As Label
    Friend WithEvents cbxSound As CheckBox
End Class
