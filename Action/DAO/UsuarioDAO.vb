Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Security.Policy
Imports Action.classes
Imports Action.Conexao

Namespace DAO

    Public Class UsuarioDAO




        Shared Sub DbCadastroUsuario(ByVal Usuario As Usuario)
            Try

                Dim ConexaoBD As New ConexaoBD
                Dim Cprt As New Criptografia(SHA512.Create())

                ConexaoBD.strInstrucao = "@SpIns_CadastraUsuario"
                ConexaoBD.objCommand.CommandText = "SpIns_CadastraUsuario"
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.Parameters.AddWithValue("@Nome", Usuario.Nome)
                ConexaoBD.objCommand.Parameters.AddWithValue("@Usuario", Usuario.Usuario)
                ConexaoBD.objCommand.Parameters.AddWithValue("@Senha", Cprt.CriptografarSenha(Usuario.Senha))
                ConexaoBD.objCommand.Parameters.AddWithValue("@DataCadastro", Usuario.DataCadastro)
                ConexaoBD.objCommand.Parameters.AddWithValue("@Permissao", Cprt.CriptografarSenha(Usuario.Permissao))
                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Sub

        Shared Sub DbAtualizaCadastro(ByVal Usuario As Usuario)

            Try


                Dim ConexaoBD As New ConexaoBD
                Dim Cprt As New Criptografia(SHA512.Create())

                ConexaoBD.strInstrucao = "@SpUpd_AlteraUsuario"
                ConexaoBD.objCommand.CommandText = "SpUpd_AlteraUsuario"
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", Usuario.Id)
                ConexaoBD.objCommand.Parameters.AddWithValue("@Nome", Usuario.Nome)
                ConexaoBD.objCommand.Parameters.AddWithValue("@Usuario", Usuario.Usuario)
                ConexaoBD.objCommand.Parameters.AddWithValue("@Senha", Cprt.CriptografarSenha(Usuario.Senha))
                ConexaoBD.objCommand.Parameters.AddWithValue("@Permissao", Cprt.CriptografarSenha(Usuario.Permissao))

                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Shared Sub DbExcluirCadastro(ByVal IdCliente As Integer)
            Try

                Dim ConexaoBD As New ConexaoBD
                Dim Cprt As New Criptografia(SHA512.Create())

                ConexaoBD.strInstrucao = "@SpDel_DeletaUsuario"
                ConexaoBD.objCommand.CommandText = "SpDel_DeletaUsuario"
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                'objCommand.Connection = objConexao
                ConexaoBD.objCommand.Parameters.AddWithValue("@ID", IdCliente)

                ConexaoBD.objCommand.ExecuteNonQuery()
                ConexaoBD.objConexao.Close()
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Sub

        Shared Function DbConsultarUsuario() As DataTable

            Try

                Dim ConexaoBD As New ConexaoBD
                Dim Cprt As New Criptografia(SHA512.Create())

                Dim dt As New DataTable
                Dim ds As New DataSet()
                ConexaoBD.strInstrucao = "SpSel_ConsultaUsuario"
                ConexaoBD.objCommand.CommandText = ConexaoBD.strInstrucao
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.Connection = ConexaoBD.objConexao


                Dim da As New SqlDataAdapter(ConexaoBD.objCommand)
                da.Fill(ds)
                dt = ds.Tables(0)

                ConexaoBD.objConexao.Close()
                Return dt
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try



        End Function

        Shared Function DbConsultarUsuarioLogado(objUsuarioLogado As Usuario) As DataTable

            Try

                Dim ConexaoBD As New ConexaoBD
                Dim Cprt As New Criptografia(SHA512.Create())

                Dim dt As New DataTable
                Dim ds As New DataSet()
                ConexaoBD.strInstrucao = "SpSel_ConsultaUsuario"
                ConexaoBD.objCommand.CommandText = ConexaoBD.strInstrucao
                ConexaoBD.objCommand.Parameters.AddWithValue("@Usuario", objUsuarioLogado.Usuario)
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.Connection = ConexaoBD.objConexao


                Dim da As New SqlDataAdapter(ConexaoBD.objCommand)
                da.Fill(ds)
                dt = ds.Tables(0)

                ConexaoBD.objConexao.Close()
                Return dt
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try



        End Function

        Shared Function DbValidaAcesso(vLogin As String, vSenha As String) As DataTable

            Try


                Dim ConexaoBD As New ConexaoBD
                Dim Cprt As New Criptografia(SHA512.Create())

                Dim dt As New DataTable
                Dim ds As New DataSet()
                ConexaoBD.strInstrucao = "@SpSel_ConsultaUsuario"
                ConexaoBD.objCommand.CommandText = "SpSel_ConsultaUsuario"
                ConexaoBD.objCommand.CommandType = CommandType.StoredProcedure
                ConexaoBD.objCommand.Parameters.AddWithValue("@Usuario", vLogin)
                ConexaoBD.objCommand.Parameters.AddWithValue("@Senha", Cprt.CriptografarSenha(vSenha))




                Dim da As New SqlDataAdapter(ConexaoBD.objCommand)
                da.Fill(ds)
                dt = ds.Tables(0)


                ConexaoBD.objConexao.Close()
                Return dt
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            'Dim conexaoBD As New ConexaoBD
            'Dim dr As SqlDataReader
            'Dim vRetorno As Boolean
            'conexaoBD.objCommand.CommandText = "Select * from tabUsuario where usuario = @vLogin and senha= @vSenha"
            'conexaoBD.objCommand.Parameters.AddWithValue("@vLogin", vLogin)
            'conexaoBD.objCommand.Parameters.AddWithValue("@vSenha", vSenha)
            'hashTxtSenha = vSenha

            'Try
            '        
            '        dr = conexaoBD.objCommand.ExecuteReader()
            '    If dr.HasRows Then

            '        vRetorno = True

            '        If Hash.VerificarSenha(hashTxtSenha, vSenha) Then
            '            vRetorno = True
            '        Else
            '            vRetorno = False
            '        End If
            '    End If
            'Catch ex As SqlException

            '        MsgBox(ex.Message)

            '    End Try

            'Return vRetorno
        End Function

    End Class


End Namespace


