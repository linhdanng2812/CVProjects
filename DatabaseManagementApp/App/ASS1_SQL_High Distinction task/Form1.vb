Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports System.Configuration

Public Class Form1
    Private Sub TestOracle()

    End Sub

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click


        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = ConfigurationManager.ConnectionStrings("myConn").ConnectionString
        rvConn.Open()

        Dim cmd As New OracleCommand("ADD_CUST_TO_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction


        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("custid", OracleDbType.Int16)).Value = txtCustid.Text
        cmd.Parameters.Add(New OracleParameter("custname", OracleDbType.Varchar2)).Value = txtCustname.Text
        txtExeResult.Text = "Adding Customer. ID: " & txtCustid.Text & " Name: " & txtCustname.Text
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
            Exit Sub
            Return
        End Try
        txtExeResult.Text = txtExeResult.Text & $"{Environment.NewLine} Customer Added OK"

        txtCustid.Text = ""
        txtCustname.Text = ""
        txtCustAmt.Text = ""
        txtStatus.Text = ""

    End Sub

    Private Sub btnCustUpdateSales_Click(sender As Object, e As EventArgs) Handles btnCustUpdateSales.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("UPD_CUST_SALESYTD_IN_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("custid", OracleDbType.Int16)).Value = txtCustid.Text
        cmd.Parameters.Add(New OracleParameter("amt", OracleDbType.Int16)).Value = txtCustAmt.Text
        txtExeResult.Text = "Updating SalesYTD. Customer Id: " & txtCustid.Text & " Amount:" & txtCustAmt.Text


        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
            Exit Sub
        End Try
        txtExeResult.Text = txtExeResult.Text & $"{Environment.NewLine} Update OK"

        rvConn.Close()

        txtCustid.Text = ""
        txtCustname.Text = ""
        txtCustAmt.Text = ""
        txtStatus.Text = ""
    End Sub

    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()


        Dim cmd As New OracleCommand("UPD_CUST_STATUS_IN_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("custid", OracleDbType.Int16)).Value = txtCustid.Text
        cmd.Parameters.Add(New OracleParameter("status", OracleDbType.Varchar2)).Value = txtStatus.Text
        txtExeResult.Text = "Updating Status. Id: " & txtCustid.Text & " New Status:" & txtStatus.Text
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
            Exit Sub
        End Try
        txtExeResult.Text = txtExeResult.Text & $"{Environment.NewLine} Updated new Status!"

        rvConn.Close()

        txtCustid.Text = ""
        txtCustname.Text = ""
        txtCustAmt.Text = ""
        txtStatus.Text = ""
    End Sub

    Private Sub btnDelCust_Click(sender As Object, e As EventArgs) Handles btnDelCust.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()


        Dim cmd As New OracleCommand("DELETE_ALL_CUSTOMERS_FROM_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add(New OracleParameter("result", OracleDbType.Int16)).Direction = ParameterDirection.ReturnValue
        txtExeResult.Text = "Deleting all Customer rows"
        Dim paramOracle As OracleParameter
        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pReturnValue"
        paramOracle.DbType = DbType.Int16
        paramOracle.Size = 200
        paramOracle.Direction = ParameterDirection.ReturnValue
        cmd.Parameters.Add(paramOracle)

        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            Dim vStr As String
            vStr = cmd.Parameters.Item("pReturnValue").Value.ToString
            txtExeResult.Text = "Deleted All successfully! " & vStr & " rows deleted"
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
            Exit Sub
        End Try

        txtCustid.Text = ""
        txtCustname.Text = ""
        txtCustAmt.Text = ""
        txtStatus.Text = ""
    End Sub

    Private Sub btnCustGet_Click(sender As Object, e As EventArgs) Handles btnCustGet.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()

        Dim cmd As New OracleCommand("GET_CUST_STRING_FROM_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure

        Dim paramOracle As OracleParameter

        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pReturnValue"
        paramOracle.DbType = DbType.String
        paramOracle.Size = 200
        paramOracle.Direction = ParameterDirection.ReturnValue
        cmd.Parameters.Add(paramOracle)

        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pcustid"
        paramOracle.DbType = DbType.Int16
        paramOracle.Value = txtCustid.Text
        paramOracle.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paramOracle)
        txtExeResult.Text = "Getting Details for CustId " & txtCustid.Text
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            Dim vStr As String
            vStr = cmd.Parameters.Item("pReturnValue").Value.ToString
            txtExeResult.Text = txtExeResult.Text & Environment.NewLine & vStr
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

        txtCustid.Text = ""
        txtCustname.Text = ""
        txtCustAmt.Text = ""
        txtStatus.Text = ""
    End Sub

    Private Sub btnCustSum_Click(sender As Object, e As EventArgs) Handles btnCustSum.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()

        Dim cmd As New OracleCommand("SUM_CUST_SALESYTD", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        txtExeResult.Text = "Summing Customer SalesYTD"
        Dim paramOracle As OracleParameter

        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pReturnValue"
        paramOracle.DbType = DbType.Int16
        paramOracle.Size = 200
        paramOracle.Direction = ParameterDirection.ReturnValue
        cmd.Parameters.Add(paramOracle)


        Try
            cmd.ExecuteScalar()
            transaction.Commit()
            Dim vStr As String
            vStr = cmd.Parameters.Item("pReturnValue").Value.ToString
            txtExeResult.Text = txtExeResult.Text & $"{Environment.NewLine} All Customer Total:  " & vStr
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

        txtCustid.Text = ""
        txtCustname.Text = ""
        txtCustAmt.Text = ""
        txtStatus.Text = ""
    End Sub

    Private Sub btnAddProd_Click(sender As Object, e As EventArgs) Handles btnAddProd.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("ADD_PRODUCT_TO_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("prodid", OracleDbType.Int16)).Value = txtProdid.Text
        cmd.Parameters.Add(New OracleParameter("prodname", OracleDbType.Varchar2)).Value = txtProdname.Text
        cmd.Parameters.Add(New OracleParameter("price", OracleDbType.Int16)).Value = txtPrice.Text

        txtExeResult.Text = "Adding Product. ID: " & txtProdid.Text & " Name: " & txtProdname.Text & " Price: " & txtPrice.Text
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            rvConn.Close()
            txtExeResult.Text = txtExeResult.Text & $"{Environment.NewLine} Product Added OK"
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

        rvConn.Close()

        txtProdid.Text = ""
        txtProdname.Text = ""
        txtProdAmt.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btnDelProd_Click(sender As Object, e As EventArgs) Handles btnDelProd.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()


        Dim cmd As New OracleCommand("DELETE_ALL_PRODUCTS_FROM_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure

        Dim paramOracle As OracleParameter
        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pReturnValue"
        paramOracle.DbType = DbType.Int16
        paramOracle.Size = 200
        paramOracle.Direction = ParameterDirection.ReturnValue
        cmd.Parameters.Add(paramOracle)
        txtExeResult.Text = "Deleting all Product rows"
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            Dim vStr As String
            vStr = cmd.Parameters.Item("pReturnValue").Value.ToString
            txtExeResult.Text = txtExeResult.Text & " " & vStr & " rows deleted"
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

        txtProdid.Text = ""
        txtProdname.Text = ""
        txtProdAmt.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btnProdGet_Click(sender As Object, e As EventArgs) Handles btnProdGet.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()

        Dim cmd As New OracleCommand("GET_PROD_STRING_FROM_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add(New OracleParameter("result", OracleDbType.Int16)).Direction = ParameterDirection.ReturnValue
        Dim paramOracle As OracleParameter

        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pReturnValue"
        paramOracle.DbType = DbType.String
        paramOracle.Size = 200
        paramOracle.Direction = ParameterDirection.ReturnValue
        cmd.Parameters.Add(paramOracle)

        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pprodid"
        paramOracle.DbType = DbType.Int16
        paramOracle.Value = txtProdid.Text
        paramOracle.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paramOracle)
        txtExeResult.Text = "Getting Details for Prod Id " & txtProdid.Text

        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            Dim vStr As String
            vStr = cmd.Parameters.Item("pReturnValue").Value.ToString
            txtExeResult.Text = txtExeResult.Text & Environment.NewLine & vStr
            rvConn.Close()
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

        txtProdid.Text = ""
        txtProdname.Text = ""
        txtProdAmt.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btnProdUpdateSales_Click(sender As Object, e As EventArgs) Handles btnProdUpdateSales.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("UPD_PROD_SALESYTD_IN_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("prodid", OracleDbType.Int16)).Value = txtProdid.Text
        cmd.Parameters.Add(New OracleParameter("prodamt", OracleDbType.Int16)).Value = txtProdAmt.Text

        txtExeResult.Text = "Updating SalesYTD Product Id: " & txtProdid.Text & " Amount: " & txtProdAmt.Text
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            rvConn.Close()
            txtExeResult.Text = txtExeResult.Text & Environment.NewLine & "Update OK"
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

        rvConn.Close()

        txtProdid.Text = ""
        txtProdname.Text = ""
        txtProdAmt.Text = ""
        txtPrice.Text = ""
    End Sub

    Private Sub btnAddSimple_Click(sender As Object, e As EventArgs) Handles btnAddSimple.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("ADD_SIMPLE_SALE_TO_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("custid", OracleDbType.Int16)).Value = txtSalesCustid.Text
        cmd.Parameters.Add(New OracleParameter("prodid", OracleDbType.Int16)).Value = txtSalesProdid.Text
        cmd.Parameters.Add(New OracleParameter("quantity", OracleDbType.Int16)).Value = txtQuantity.Text

        txtExeResult.Text = "Adding Simple Sale. Cust Id: " & txtSalesCustid.Text & " Prod Id: " & txtSalesProdid.Text & " Qty: " & txtQuantity.Text
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            rvConn.Close()
            txtExeResult.Text = txtExeResult.Text & Environment.NewLine & "Added Simple Sale OK"
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
        rvConn.Close()

        txtSalesCustid.Text = ""
        txtSalesProdid.Text = ""
        txtQuantity.Text = ""
        txtDate.Text = ""
        txtDateNum.Text = ""
    End Sub

    Private Sub btnAllProd_Click(sender As Object, e As EventArgs) Handles btnAllProd.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("cursPackage.get_all_prod", rvConn)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("i_cursor", OracleDbType.RefCursor)).Direction = ParameterDirection.Output
        Dim rd As OracleDataReader
        rd = cmd.ExecuteReader
        Try
            If rd.HasRows Then
                While rd.Read
                    Dim eStr As String() = {rd(0).ToString, rd(1).ToString, rd(2).ToString, rd(3).ToString}
                    ProdGrid.Rows.Add(eStr)
                End While
            Else
                MsgBox("No rows found")
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        Finally
            rd.Close()
            cmd.Dispose()
        End Try

        txtSalesCustid.Text = ""
        txtSalesProdid.Text = ""
        txtQuantity.Text = ""
        txtDate.Text = ""
        txtDateNum.Text = ""
    End Sub

    Private Sub btnAllCust_Click(sender As Object, e As EventArgs) Handles btnAllCust.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("cursPackage.get_all_cust", rvConn)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("i_cursor", OracleDbType.RefCursor)).Direction = ParameterDirection.Output
        Dim rd As OracleDataReader
        rd = cmd.ExecuteReader
        Try
            If rd.HasRows Then
                While rd.Read
                    Dim eStr As String() = {rd(0).ToString, rd(1).ToString, rd(2).ToString, rd(3).ToString}
                    CustGrid.Rows.Add(eStr)

                End While
            Else
                MsgBox("No rows found")
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        Finally
            rd.Close()
            cmd.Dispose()
        End Try
    End Sub

    Private Sub btnAddLoc_Click(sender As Object, e As EventArgs) Handles btnAddLoc.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("ADD_LOCATION_TO_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("locid", OracleDbType.Varchar2)).Value = txtLocid.Text
        cmd.Parameters.Add(New OracleParameter("min", OracleDbType.Int16)).Value = txtMinqty.Text
        cmd.Parameters.Add(New OracleParameter("max", OracleDbType.Int16)).Value = txtMaxQty.Text
        txtExeResult.Text = "Adding Location LocCode: " & txtLocid.Text & " MinQty: " & txtMinqty.Text & " MaxQty: " & txtMaxQty.Text
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            rvConn.Close()
            txtExeResult.Text = txtExeResult.Text & Environment.NewLine & "Location Added OK"
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

        rvConn.Close()

        txtLocid.Text = ""
        txtMinqty.Text = ""
        txtMaxQty.Text = ""
    End Sub

    Private Sub btnAddComplex_Click(sender As Object, e As EventArgs) Handles btnAddComplex.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("ADD_COMPLEX_SALE_TO_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("custid", OracleDbType.Int16)).Value = txtSalesCustid.Text
        cmd.Parameters.Add(New OracleParameter("prodid", OracleDbType.Int16)).Value = txtSalesProdid.Text
        cmd.Parameters.Add(New OracleParameter("qty", OracleDbType.Int16)).Value = txtQuantity.Text
        cmd.Parameters.Add(New OracleParameter("date", OracleDbType.Varchar2)).Value = txtDate.Text
        txtExeResult.Text = "Adding Complex Sale. Cust Id: " & txtSalesCustid.Text & " Prod Id: " & txtSalesProdid.Text & " Date: " & txtDate.Text & " Amt: " & txtQuantity.Text
        Dim rd As OracleDataReader
        Try
            rd = cmd.ExecuteReader
            transaction.Commit()
            rd.Close()
            txtExeResult.Text = txtExeResult.Text & Environment.NewLine & "Added Complex Sale OK"
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try

        rvConn.Close()

        txtSalesCustid.Text = ""
        txtSalesProdid.Text = ""
        txtQuantity.Text = ""
        txtDate.Text = ""
        txtDateNum.Text = ""
    End Sub

    Private Sub btnAllSales_Click(sender As Object, e As EventArgs) Handles btnAllSales.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("cursPackage.get_all_sale", rvConn)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("i_cursor", OracleDbType.RefCursor)).Direction = ParameterDirection.Output
        Dim rd As OracleDataReader
        rd = cmd.ExecuteReader
        Try
            If rd.HasRows Then
                While rd.Read
                    Dim eStr As String() = {rd(0).ToString, rd(1).ToString, rd(2).ToString, rd(3).ToString, rd(4).ToString, rd(5).ToString}
                    SaleGrid.Rows.Add(eStr)
                End While
            Else
                MsgBox("No rows found")
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        Finally
            rd.Close()
            cmd.Dispose()
        End Try

        txtSalesCustid.Text = ""
        txtSalesProdid.Text = ""
        txtQuantity.Text = ""
        txtDate.Text = ""
        txtDateNum.Text = ""
    End Sub

    Private Sub btnDel1Cust_Click(sender As Object, e As EventArgs) Handles btnDel1Cust.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("DELETE_CUSTOMER", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("custid", OracleDbType.Int16)).Value = txtCustid.Text
        txtExeResult.Text = "Deleting Customer. Cust Id: " & txtCustid.Text
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            rvConn.Close()
            txtExeResult.Text = txtExeResult.Text & Environment.NewLine & "Deleted Customer OK."
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
        rvConn.Close()

        txtCustid.Text = ""
        txtCustname.Text = ""
        txtCustAmt.Text = ""
        txtStatus.Text = ""

    End Sub

    Private Sub btnDell1Prod_Click(sender As Object, e As EventArgs) Handles btnDell1Prod.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()
        Dim cmd As New OracleCommand("DELETE_PROD_FROM_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New OracleParameter("prodid", OracleDbType.Int16)).Value = txtProdid.Text
        txtExeResult.Text = "Deleting Product. Product Id: " & txtProdid.Text
        Try
            cmd.ExecuteNonQuery()
            transaction.Commit()
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
        txtExeResult.Text = txtExeResult.Text & Environment.NewLine & "Deleted Product OK."
        rvConn.Close()

        txtProdid.Text = ""
        txtProdname.Text = ""
        txtProdAmt.Text = ""
        txtPrice.Text = ""

    End Sub

    Private Sub btnCountSales_Click(sender As Object, e As EventArgs) Handles btnCountSales.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()

        Dim cmd As New OracleCommand("COUNT_PRODUCT_SALES_FROM_DB", rvConn)
        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction
        cmd.CommandType = CommandType.StoredProcedure

        Dim paramOracle As OracleParameter

        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pReturnValue"
        paramOracle.DbType = DbType.Int16
        paramOracle.Size = 200
        paramOracle.Direction = ParameterDirection.ReturnValue
        cmd.Parameters.Add(paramOracle)

        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pdays"
        paramOracle.DbType = DbType.Int16
        paramOracle.Value = txtDateNum.Text
        paramOracle.Direction = ParameterDirection.Input
        cmd.Parameters.Add(paramOracle)
        txtExeResult.Text = $"Counting sales within {txtDateNum.Text} days"
        Try
            cmd.ExecuteScalar()
            Dim vStr As String
            vStr = cmd.Parameters.Item("pReturnValue").Value.ToString
            txtExeResult.Text = txtExeResult.Text & Environment.NewLine & "Total number of sales: " & vStr
            transaction.Commit()
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub btnDelSmallest_Click(sender As Object, e As EventArgs) Handles btnDelSmallest.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()

        Dim cmd As New OracleCommand("DELETE_SALE_FROM_DB", rvConn)
        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction
        cmd.CommandType = CommandType.StoredProcedure

        Dim paramOracle As OracleParameter
        txtExeResult.Text = "Deleting Sale with smallest SaleId value"
        paramOracle = New OracleParameter
        paramOracle.ParameterName = "pReturnValue"
        paramOracle.DbType = DbType.Int16
        paramOracle.Size = 200
        paramOracle.Direction = ParameterDirection.ReturnValue
        cmd.Parameters.Add(paramOracle)

        Try
            cmd.ExecuteScalar()
            Dim vStr As String
            vStr = cmd.Parameters.Item("pReturnValue").Value.ToString
            txtExeResult.Text = txtExeResult.Text & Environment.NewLine & "Deleted Sale OK. SaleID: " & vStr
            transaction.Commit()
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub btnDelAllSales_Click(sender As Object, e As EventArgs) Handles btnDelAllSales.Click
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SID=dms)));"
        vConnStr = vConnStr & "User Id=s103488557;"
        vConnStr = vConnStr & "Password=JulieatSwin@2812;"

        Dim rvConn As New OracleConnection
        rvConn.ConnectionString = vConnStr
        rvConn.Open()

        Dim cmd As New OracleCommand("DELETE_ALL_SALES_FROM_DB", rvConn)

        Dim transaction As OracleTransaction
        transaction = rvConn.BeginTransaction
        cmd.Transaction = transaction

        cmd.CommandType = CommandType.StoredProcedure
        txtExeResult.Text = "Deleting all Sales data in Sale, Customer, and Product tables"
        Try
            cmd.ExecuteNonQuery()
            txtExeResult.Text = txtExeResult.Text & "Deletion OK"
            transaction.Commit()
            rvConn.Close()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub btnClear1_Click(sender As Object, e As EventArgs) Handles btnClear1.Click
        CustGrid.Rows.Clear()
        CustGrid.Refresh()
    End Sub

    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        ProdGrid.Rows.Clear()
        ProdGrid.Refresh()
    End Sub

    Private Sub btnClear3_Click(sender As Object, e As EventArgs) Handles btnClear3.Click
        SaleGrid.Rows.Clear()
        SaleGrid.Refresh()
    End Sub

End Class
