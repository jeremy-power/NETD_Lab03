Option Strict On

' ---------------------------------------------'
' Name: Jeremy Power 100523300                 '
' Date: May 31, 2017                           '
' Purpose: Lab 2                               '
' Description: Golf Traacker Form              '
' Allows the user to enter a golf score, the   '
' program then displays the score and          '
' compares that score with the par of the      '
' hole to give the user a result (ie bogey)    '
' ---------------------------------------------'



Public Class DeathStarForm1

    Private Const _GRID_SIZE As Integer = 15
    Private _FIELD_ARRAY(_GRID_SIZE - 1, _GRID_SIZE) As Integer
    Dim _PLANETS_PLACED As Integer = 0

    Private Sub DeathStarForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New System.Drawing.Size(650, 705)
        gbxPlayMode.Location = gbxSetup.Location
        gbxPlayMode.Visible = False
        populateArray()
        setUpDGV()
        populateDGV()



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub populateArray()
        For row As Integer = 0 To _GRID_SIZE - 1
            For col As Integer = 0 To _GRID_SIZE
                _FIELD_ARRAY(row, col) = 0
            Next
        Next
    End Sub

    Private Sub setUpDGV()
        dgvBattlefield.RowHeadersVisible = False

        dgvBattlefield.Columns.Clear()
        Dim column As DataGridViewTextBoxColumn

        For colNum = 0 To _GRID_SIZE
            column = New DataGridViewTextBoxColumn
            column.HeaderText = colNum.ToString
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            column.SortMode = DataGridViewColumnSortMode.NotSortable
            column.Width = 30

            dgvBattlefield.Columns.Add(column)
        Next
    End Sub

    Private Sub populateDGV()
        dgvBattlefield.Rows.Clear()
        Dim row As DataGridViewRow

        Dim cell As DataGridViewCell

        For R As Integer = 0 To _GRID_SIZE - 1
            row = New DataGridViewRow
            row.Height = 24

            For C As Integer = 0 To _GRID_SIZE
                cell = New DataGridViewTextBoxCell
                If C = 0 Then
                    cell.Style.BackColor = Color.Gray
                    cell.Style.ForeColor = Color.Black
                    cell.Value = R + 1
                    cell.Style.SelectionBackColor = cell.Style.BackColor
                    cell.Style.SelectionForeColor = cell.Style.ForeColor

                Else
                    cell.Style.BackColor = Color.Black
                    cell.Style.ForeColor = Color.White
                    cell.Value = _FIELD_ARRAY(R, C)
                End If
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                row.Cells.Add(cell)
            Next
            dgvBattlefield.Rows.Add(row)
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub addPlanet(ByVal x As Integer, ByVal y As Integer)
        If (x >= 0 And y >= 0) Then
            If y <> 0 Then
                If _PLANETS_PLACED < nudPlanetNum.Value Then
                    _FIELD_ARRAY(x, y) = 1
                    _PLANETS_PLACED += 1
                Else
                    MessageBox.Show("Too many planets placed!", "Error - Too Many Planets")
                End If
            End If
        End If

        Call populateDGV()
    End Sub

    Private Sub dgvBattlefield_CellClick(sender As Object,
                                        e As DataGridViewCellEventArgs) Handles dgvBattlefield.CellClick
        Dim r As Integer = 0
        Dim c As Integer = 0

        r = e.RowIndex
        c = e.ColumnIndex

        addPlanet(r, c)
    End Sub

End Class