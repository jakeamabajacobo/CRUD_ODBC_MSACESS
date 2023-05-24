Imports System.Data.Odbc
Public Class form_main


    Dim con = New OdbcConnection("DRIVER={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=C:\\Users\\pc\\Documents\\inventorydb.accdb;DSN=host;")
    Dim cmd As New OdbcCommand
    Dim adpt As OdbcDataAdapter
    Dim dt As New DataTable
    Dim rd As OdbcDataReader
    Dim stringqry As String
    Function ClearTable()
        dg_view_item.DataSource = Nothing
        dt.Clear()
        dg_view_item.Refresh()
    End Function

    Function ClearInputFields()
        txt_itemname.Text = ""
        txt_itemdescription.Text = ""
        txt_price.Text = ""
        txt_qty.Text = ""
    End Function

    Private Function RowSelectionData()

        Me.Text = dg_view_item.CurrentRow.Cells(0).Value
        txt_itemname.Text = dg_view_item.CurrentRow.Cells(1).Value
        txt_itemdescription.Text = dg_view_item.CurrentRow.Cells(2).Value
        txt_qty.Text = dg_view_item.CurrentRow.Cells(3).Value
        txt_price.Text = dg_view_item.CurrentRow.Cells(4).Value

    End Function


    Function ClearTxtBox()
        txt_itemname.Clear()
        txt_itemdescription.Clear()
        txt_price.Clear()
        txt_qty.Clear()
    End Function

    Function DBProcess(ByVal stringqry As String, ByVal conF As OdbcConnection, ByVal isTable As Boolean)
        Try
            If con.State = ConnectionState.Closed Then con.Open()

            cmd.Connection = conF
            cmd.CommandText = stringqry
            adpt = New OdbcDataAdapter
            adpt.SelectCommand = cmd

            If isTable = True Then
                adpt.Fill(dt)
                Return dt
            Else
                Return cmd.ExecuteNonQuery()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Function




    Private Sub form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_view_item.DataSource = DBProcess("SELECT * FROM tblitems", con, True)
    End Sub


    Private Sub dg_view_item_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_view_item.CellClick
        RowSelectionData()

    End Sub

    Private Sub dg_view_item_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_view_item.CellContentClick
        RowSelectionData()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        dg_view_item.DataSource = DBProcess("INSERT INTO tblitems(ITEMNAME,ITEMDESCRIPTION,QTY,PRICE) VALUES ('" & txt_itemname.Text & "','" & txt_itemdescription.Text & "','" & Val(txt_qty.Text) & "','" & Val(txt_price.Text) & "');", con, True)
        MsgBox("Item saved!")
        ClearInputFields()
        ClearTable()
        dg_view_item.DataSource = DBProcess("SELECT * FROM tblitems", con, True)

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If DBProcess("UPDATE tblitems SET ITEMNAME='" & txt_itemname.Text & "',ITEMDESCRIPTION='" & txt_itemdescription.Text & "',QTY=" & Val(txt_qty.Text) & ",PRICE=" & Val(txt_price.Text) & " WHERE ID=" & Val(Me.Text) & "", con, False) Then
            MsgBox("Item Updated!")
            ClearInputFields()
            ClearTable()
            dg_view_item.DataSource = DBProcess("SELECT * FROM tblitems", con, True)
        Else
            MsgBox("Item NOT UPDATE!")
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If DBProcess("DELETE  * FROM tblitems WHERE ID=" & Val(Me.Text) & "", con, False) Then
            MsgBox("Item  DELETED!!")
            ClearInputFields()
            ClearTable()
            dg_view_item.DataSource = DBProcess("SELECT * FROM tblitems", con, True)
        Else
            MsgBox("Item NOT DELETED!")
        End If
    End Sub

    Private Sub btn_loadrecord_Click(sender As Object, e As EventArgs) Handles btn_loadrecord.Click

        form_report.Show()
        dt.Clear()
        With form_report.report_viewer.LocalReport
            .DataSources.Clear()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("Dataset_holder", DBProcess("SELECT * FROM tblitems", con, True)))
        End With
        form_report.report_viewer.RefreshReport
    End Sub
End Class
