Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnIngresoVehiculos_Click(sender As Object, e As EventArgs) Handles btnIngresoVehiculos.Click
        Dim dtVehiculos As New DataTable
        dtVehiculos = ConsultaDB("SELECT * FROM Vehiculos")
        dgvPrueba.DataSource = dtVehiculos
    End Sub
End Class
