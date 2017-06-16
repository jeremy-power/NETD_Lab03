Option Strict On

' ---------------------------------------------'
' Name: Jeremy Power & Minh Tri Ly             '
' Date: May 31, 2017                           '
' Purpose: Lab 3                               '
' Description: Battle Death Star               '
' Allows the user to play a game of battleship '
' with a data grid view and a star wars theme  '
'----------------------------------------------'



Public Class DeathStarForm1
#Region "Global Variables and Constants"
    'size of grid
    Private Const _GRID_SIZE As Integer = 15
    'array to hold cell data
    Private _FIELD_ARRAY(_GRID_SIZE - 1, _GRID_SIZE) As Integer
    'array to hold star picture data
    Private _STAR_ARRAY(_GRID_SIZE - 1, _GRID_SIZE) As Integer
    'values for game state
    Dim _PLANETS_PLACED As Integer = 0
    Dim _SHOTS_FIRED As Integer = 0
    Dim _ALREADY_PLACED As Boolean = False
    Dim _PLANETS_DESTROYED As Integer = 0
    Dim rand As New Random
#End Region
    ''' <summary>
    ''' Form Load Event Handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeathStarForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(650, 705)
        gbxPlayMode.Location = gbxSetup.Location
        gbxPlayMode.Visible = False
        setUpStars()
        populateArray()
        setUpDGV()
        populateDGV()

    End Sub

    ''' <summary>
    ''' Creates an array of random numbers 1-4 for star pictures
    ''' </summary>
    Private Sub setUpStars()
        'for each row
        For row As Integer = 0 To _GRID_SIZE - 1
            'each column in that row
            For col As Integer = 0 To _GRID_SIZE
                'create a random # 1-4
                _STAR_ARRAY(row, col) = rand.Next(1, 5)
            Next
        Next
    End Sub

    ''' <summary>
    ''' Event Handler for Help Picture box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbxHelp_Click(sender As Object, e As EventArgs) Handles pbxHelp.Click
        frmHelp.ShowDialog()
    End Sub

    ''' <summary>
    ''' Fills grid array with 0's
    ''' </summary>
    Private Sub populateArray()
        For row As Integer = 0 To _GRID_SIZE - 1
            For col As Integer = 0 To _GRID_SIZE
                _FIELD_ARRAY(row, col) = 0
            Next
        Next
        _PLANETS_PLACED = 0
        _ALREADY_PLACED = False
    End Sub

    ''' <summary>
    ''' Creates all the columns in datagrid view
    ''' </summary>
    Private Sub setUpDGV()
        'turns row headers off
        dgvBattlefield.RowHeadersVisible = False
        'empties all columns
        dgvBattlefield.Columns.Clear()
        Dim column As DataGridViewColumn
        'for each column
        For colNum = 0 To _GRID_SIZE
            column = New DataGridViewColumn
            'style it
            column.HeaderText = colNum.ToString
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.SortMode = DataGridViewColumnSortMode.NotSortable
            column.Width = 30
            'add it to the view
            dgvBattlefield.Columns.Add(column)
        Next
    End Sub

    ''' <summary>
    ''' Fills the cells in the DGV with data and styles them
    ''' </summary>
    Private Sub populateDGV()
        dgvBattlefield.Rows.Clear()

        Dim row As DataGridViewRow

        Dim cell As DataGridViewCell
        'for each row (1 less row because of the column of headers)
        For R As Integer = 0 To _GRID_SIZE - 1
            row = New DataGridViewRow
            row.Height = 24
            'for each of 16 cells per row
            For C As Integer = 0 To _GRID_SIZE
                cell = New DataGridViewTextBoxCell
                'if in the first column create a "header cell"
                If C = 0 Then
                    'styles it to be unclickable and sets value to the row #
                    cell.Style.BackColor = Color.Gray
                    cell.Style.ForeColor = Color.Black
                    cell.Value = R + 1
                    cell.Style.SelectionBackColor = cell.Style.BackColor
                    cell.Style.SelectionForeColor = cell.Style.ForeColor
                    'if not in the first row
                Else
                    'if in test mode draw all font as white on black
                    If cbxTestMode.Checked Then
                        cell.Style.BackColor = Color.Black
                        cell.Style.ForeColor = Color.White
                        'if not in test mode draw black on black
                    Else
                        cell.Style.BackColor = Color.Black
                        cell.Style.ForeColor = Color.Black
                        cell.Style.SelectionBackColor = cell.Style.BackColor
                        cell.Style.SelectionForeColor = cell.Style.ForeColor
                        'unless the cell is a miss, draw black on white
                        If _FIELD_ARRAY(R, C) = 2 Then
                            cell.Style.BackColor = Color.White
                            cell.Style.ForeColor = Color.Black
                            'if the cell is a hit, draw black on red
                        ElseIf _FIELD_ARRAY(R, C) = 3 Then
                            cell.Style.BackColor = Color.Red
                            cell.Style.ForeColor = Color.Black
                        End If
                    End If
                    'set the value of the cell to the value in the array
                    cell.Value = _FIELD_ARRAY(R, C)
                End If
                'add each cell to the row
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                row.Cells.Add(cell)
            Next
            'add each row to the DGV
            dgvBattlefield.Rows.Add(row)
        Next
    End Sub

    ''' <summary>
    ''' Populates the DGV if images enabled
    ''' differences from populateDGV() are commented
    ''' </summary>
    Private Sub populateImageDGV()

        dgvBattlefield.Rows.Clear()
        Dim row As DataGridViewRow

        Dim cell As DataGridViewCell

        For R As Integer = 0 To _GRID_SIZE - 1
            row = New DataGridViewRow
            row.Height = 24
            'object to hold image to print
            Dim image As Bitmap

            'starts with star image
            image = New Bitmap(My.Resources.Stars30_2)
            For C As Integer = 0 To _GRID_SIZE
                If C = 0 Then
                    cell = New DataGridViewTextBoxCell
                    cell.Style.BackColor = Color.Gray
                    cell.Style.ForeColor = Color.Black
                    cell.Value = R + 1
                    cell.Style.SelectionBackColor = cell.Style.BackColor
                    cell.Style.SelectionForeColor = cell.Style.ForeColor

                Else
                    'if no planet or we're not in test mode (can't see planets), draw stars in this cell
                    If (_FIELD_ARRAY(R, C) = 0) Or Not cbxTestMode.Checked Then
                        'draws stars based on array generated by setUpStars()
                        Select Case _STAR_ARRAY(R, C)
                            Case 1
                                image = New Bitmap(My.Resources.Stars30_1)
                            Case 2
                                image = New Bitmap(My.Resources.Stars30_2)
                            Case 3
                                image = New Bitmap(My.Resources.Stars30_3)
                            Case 4
                                image = New Bitmap(My.Resources.Stars30_4)
                        End Select

                        'otherwise either draw a planet if 1
                    Else
                        If _FIELD_ARRAY(R, C) = 1 Then
                            image = New Bitmap(My.Resources.planet30)
                        End If
                    End If
                    'a miss if 2
                    If _FIELD_ARRAY(R, C) = 2 Then
                        image = New Bitmap(My.Resources.Miss30)
                    ElseIf _FIELD_ARRAY(R, C) = 3 Then
                        'a hit if 3
                        image = New Bitmap(My.Resources.planet_Destroyed30)
                    End If

                    'creates the image cell
                    cell = New DataGridViewImageCell
                    'puts the current image in the cell
                    cell.Value = image
                End If
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                row.Cells.Add(cell)
            Next
            dgvBattlefield.Rows.Add(row)
        Next
    End Sub

    ''' <summary>
    ''' event handler for exit button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Adds a planet to the coordinate provided
    ''' </summary>
    ''' <param name="x">Integer X coordinate provided</param>
    ''' <param name="y">Integer Y coordinate provided</param>
    Private Sub addPlanet(ByVal x As Integer, ByVal y As Integer)
        'if not negative
        If (x >= 0 And y >= 0) Then
            'if not in the header column
            If y <> 0 Then
                'if no planet exists alreaedy
                If _FIELD_ARRAY(x, y) = 0 Then
                    'if max planets not exceeded
                    If _PLANETS_PLACED < nudPlanetNum.Value Then
                        'place a planet
                        _FIELD_ARRAY(x, y) = 1
                        _PLANETS_PLACED += 1
                    Else
                        MessageBox.Show("Too many planets placed!", "Error - Too Many Planets")
                    End If
                Else
                    MessageBox.Show("There is already a planet there!", "Error - Planet Already Placed")
                End If
            End If
        End If
        'reload DGV
        If cbxImages.Checked Then
            Call populateImageDGV()
        Else
            Call populateDGV()
        End If
    End Sub

    ''' <summary>
    ''' similar to addPlanet(), attempts to shoot at x and y provided
    ''' </summary>
    ''' <param name="x">Integer x coordinate provided</param>
    ''' <param name="y">Integer y coordinate provided</param>
    Private Sub shoot(ByVal x As Integer, ByVal y As Integer)
        'if not negative
        If (x >= 0 And y >= 0) Then
            'if not the row headers
            If y <> 0 Then
                'if there are shots left
                If _SHOTS_FIRED < nudMaxShots.Value Then
                    'if there is no planet
                    If _FIELD_ARRAY(x, y) = 0 Then
                        'it's a miss
                        _FIELD_ARRAY(x, y) = 2
                        _SHOTS_FIRED += 1
                        If cbxSound.Checked Then
                            My.Computer.Audio.Play(My.Resources.woosh, AudioPlayMode.Background)
                        End If
                        'if there is a planet
                    ElseIf _FIELD_ARRAY(x, y) = 1 Then
                        'it's a hit
                        _FIELD_ARRAY(x, y) = 3
                        _SHOTS_FIRED += 1
                        _PLANETS_DESTROYED += 1
                        If cbxSound.Checked Then
                            My.Computer.Audio.Play(My.Resources.explosion, AudioPlayMode.Background)
                        End If
                        'if there's already a miss
                    ElseIf _FIELD_ARRAY(x, y) = 2 Then
                            MessageBox.Show("You already fired at those coordinates and missed!", "Repeated Coordinates")
                            'if there's already a hit
                        ElseIf _FIELD_ARRAY(x, y) = 3 Then
                            MessageBox.Show("You already destroyed a planet at those coordinates!", "Repeated Coordinates")
                    End If
                    'if you destroy all the planets you win
                    If (_PLANETS_PLACED = _PLANETS_DESTROYED) Then
                        MessageBox.Show("Congratulations! You destroyed all the planets! You now rule the galaxy!", "Victory!")
                        Call resetGame()
                    End If
                Else
                    'if you run out of shots you lose
                    If _PLANETS_DESTROYED <> _PLANETS_PLACED Then
                        MessageBox.Show("FAILURE, you have run out of energy from the sun, you cannot fire anymore.", "FAILURE, You lose")
                        Call resetGame()
                    End If
                End If
            End If
        End If
        lblShotsTaken.Text = CStr(_SHOTS_FIRED)
        lblDestroyed.Text = CStr(_PLANETS_DESTROYED)
        If (_PLANETS_PLACED <> 0) Then
            lblComplete.Text = CStr(Math.Round(((CDbl(_PLANETS_DESTROYED) / CDbl(_PLANETS_PLACED))), 4) * 100) & "%"
        End If

        If cbxImages.Checked Then
            Call populateImageDGV()
        Else
            Call populateDGV()
        End If
    End Sub



    ''' <summary>
    ''' resets all game variables to default
    ''' </summary>
    Private Sub resetGame()
        Call populateArray()
        If cbxImages.Checked Then
            populateImageDGV()
        Else
            Call populateDGV()
        End If
        Call switchMode()
        nudMaxShots.Value = 25
        nudPlanetNum.Value = 10
        nudXCoord.Value = 1
        nudYCoord.Value = 1
        nudPlayX.Value = 1
        nudPlayY.Value = 1
        lblComplete.Text = "0"
        lblDestroyed.Text = "0"
        lblShotsTaken.Text = "0"
        _SHOTS_FIRED = 0
        _PLANETS_PLACED = 0
        _PLANETS_DESTROYED = 0

    End Sub


    ''' <summary>
    ''' cell click handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub dgvBattlefield_CellClick(sender As Object,
                                        e As DataGridViewCellEventArgs) Handles dgvBattlefield.CellClick
        'defines the clicked row and cell
        Dim r As Integer = 0
        Dim c As Integer = 0
        r = e.RowIndex
        c = e.ColumnIndex

        'either adds a planet or shoots
        If gbxSetup.Visible Then
            addPlanet(r, c)
        Else
            shoot(r, c)
        End If

    End Sub

    ''' <summary>
    ''' add planet button event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddPlanet_Click(sender As Object, e As EventArgs) Handles btnAddPlanet.Click
        'adds a planet to the coordinate modified for the header
        addPlanet(CInt(nudYCoord.Value) - 1, CInt(nudXCoord.Value))
    End Sub

    ''' <summary>
    ''' event handler for random buttons
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRandomPlanets_Click(sender As Object, e As EventArgs) Handles btnRandomPlanets.Click
        Call placeRandoms()
    End Sub
    ''' <summary>
    ''' places x random planets where x is the max number of planets specified
    ''' </summary>
    Private Sub placeRandoms()
        'if this button has not already been pressed
        If _ALREADY_PLACED = False Then
            'generates 10 random coordinates
            For i As Integer = 0 To (CInt(nudPlanetNum.Value) - 1 - _PLANETS_PLACED)
                Dim x As Integer = rand.Next(0, 15)
                Dim y As Integer = rand.Next(1, 16)
                'if they are on the header, re-generate
                If (_FIELD_ARRAY(x, y) = 1) Then
                    x = rand.Next(0, 15)
                    y = rand.Next(1, 16)
                    i = i - 1
                    'otherwise add the planet
                Else
                    addPlanet(x, y)
                End If
            Next
            _ALREADY_PLACED = True
        End If
    End Sub
    ''' <summary>
    ''' switches from play to setup and vice versa
    ''' </summary>
    Private Sub switchMode()
        If gbxSetup.Visible Then
            gbxSetup.Visible = False
            gbxPlayMode.Visible = True
        Else
            gbxSetup.Visible = True
            gbxPlayMode.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' reset button event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call resetGame()
        If gbxPlayMode.Visible Then
            Call switchMode()
        End If
    End Sub

    ''' <summary>
    ''' play mode button event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Call switchMode()
    End Sub

    ''' <summary>
    ''' Images check box event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxImages_CheckedChanged(sender As Object, e As EventArgs) Handles cbxImages.CheckedChanged
        If cbxImages.Checked Then
            Call populateImageDGV()
        Else
            Call populateDGV()
        End If
    End Sub

    ''' <summary>
    ''' Test Mode check box event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cbxTestMode_CheckedChanged(sender As Object, e As EventArgs) Handles cbxTestMode.CheckedChanged
        If cbxImages.Checked Then
            Call populateImageDGV()
        Else
            Call populateDGV()
        End If
    End Sub

    ''' <summary>
    ''' fire button event handler
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pbxFire_Click(sender As Object, e As EventArgs) Handles pbxFire.Click
        shoot(CInt(nudPlayX.Value - 1), CInt(nudPlayY.Value))
    End Sub
End Class