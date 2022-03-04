Imports System.Data.OleDb

Public Class Form1
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim comm As OleDbCommand
    Dim ccode As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
        da = New OleDbDataAdapter("Select * from db_course", conn)
        dset = New DataSet
        da.Fill(dset, "db_course")
        Dim count As Integer = dset.Tables("db_course").Rows.Count
        Dim x As Integer
        For x = 0 To count - 1
            cmbcourse.Items.Add(dset.Tables("db_course").Rows(x).Item("CDes"))
        Next
    End Sub

    Function populate()
        da = New OleDbDataAdapter("Select * from db_con", conn)
        dset = New DataSet
        da.Fill(dset, "db_con")
        dgv.DataSource = dset.Tables("db_con").DefaultView
    End Function

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        da = New OleDbDataAdapter("Select * from db_course where CDes='" & cmbcourse.Text & "'", conn)
        dset = New DataSet
        da.Fill(dset, "db_course")
        ccode = dset.Tables("db_course").Rows(0).Item("Ccode")

        Dim comm As OleDbCommand
        connect()

        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "Insert into db_con values('" & txtid.Text & "', '" & txtname.Text & "', '" & txtLname.Text & "', '" & txtage.Text & "', '" & ccode & "')"
        comm.ExecuteNonQuery()
        populate()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        txtid.Text = dgv.Rows(e.RowIndex).Cells(0).Value.ToString
        txtname.Text = dgv.Rows(e.RowIndex).Cells(1).Value.ToString
        txtLname.Text = dgv.Rows(e.RowIndex).Cells(2).Value.ToString
        txtage.Text = dgv.Rows(e.RowIndex).Cells(3).Value.ToString

        ccode = dgv.Rows(e.RowIndex).Cells(4).Value.ToString
        da = New OleDbDataAdapter("Select * from db_course where Ccode='" & ccode & "'", conn)
        dset = New DataSet
        da.Fill(dset, "db_course")
        cmbcourse.Text = dset.Tables("db_course").Rows(0).Item("CDes")
    End Sub

    Private Sub cmbcourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcourse.SelectedIndexChanged
        da = New OleDbDataAdapter("Select * from db_course where CDes='" & cmbcourse.Text & "'", conn)
        dset = New DataSet
        da.Fill(dset, "db_course")
        ccode = dset.Tables("db_course").Rows(0).Item("Ccode")
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        connect()

        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "Update db_con set Name='" & txtname.Text & "', LName='" & txtLname.Text & "', Age='" & txtage.Text & "', Course='" & ccode & "' where ID=@ID"
        comm.Parameters.Add("ID", OleDbType.Integer).Value = txtid.Text
        comm.ExecuteNonQuery()
        MessageBox.Show("Query Update [Click OK]")
        populate()
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        connect()
        comm = New OleDbCommand
        comm.Connection = conn
        comm.CommandText = "Delete from db_con where ID=@ID"
        comm.Parameters.Add("ID", OleDbType.Integer).Value = txtid.Text
        comm.ExecuteNonQuery()
        MessageBox.Show("Row Deleted [Click OK]")
        populate()
    End Sub
End Class
