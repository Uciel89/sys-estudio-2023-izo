Module conexion
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    'Public conexion As New SqlClient.SqlConnection("Data Source=LABP-03;Initial Catalog=ministerio_seguridad;Integrated Security=false ;user id=sa;password=izo9045")
    Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-2Q9U9EP;Initial Catalog=ministerio_seguridad;Integrated Security=false ;user id=sa;password=:Redragon564.")
    Public Sub conectar() 'FUNCION PARA ABRIR LA CONEXIONv
        Try
            conexion.Open()
            cmd.Connection = conexion
        Catch ex As Exception
            MsgBox("Error al conectar con el servidor.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Module
