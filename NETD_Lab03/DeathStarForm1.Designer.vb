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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.dgvBattlefield, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSetup.SuspendLayout()
        CType(Me.nudYCoord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudXCoord, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPlanetNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxShots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbxPlayMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPlayMode.ForeColor = System.Drawing.Color.White
        Me.gbxPlayMode.Location = New System.Drawing.Point(547, 312)
        Me.gbxPlayMode.Name = "gbxPlayMode"
        Me.gbxPlayMode.Size = New System.Drawing.Size(530, 202)
        Me.gbxPlayMode.TabIndex = 3
        Me.gbxPlayMode.TabStop = False
        Me.gbxPlayMode.Text = "Play Mode"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.help48
        Me.PictureBox1.Location = New System.Drawing.Point(566, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 46)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
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
        'DeathStarForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BattleDeathstar
        Me.ClientSize = New System.Drawing.Size(1093, 666)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbxPlayMode)
        Me.Controls.Add(Me.pnlTitle)
        Me.Controls.Add(Me.gbxSetup)
        Me.Controls.Add(Me.dgvBattlefield)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeathStarForm1"
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnAddPlanet As Button
    Friend WithEvents btnRandomPlanets As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
End Class
