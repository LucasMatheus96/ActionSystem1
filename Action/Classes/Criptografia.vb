Imports System.Security.Cryptography
Imports System.Text

Namespace classes
    Public Class Criptografia

        Private _Algoritmo As HashAlgorithm

        Sub New(Algoritmo As HashAlgorithm)

            _Algoritmo = Algoritmo
        End Sub

        Public Function CriptografarSenha(senha As String) As String


            Dim SenhaCodificar = Encoding.UTF8.GetBytes(senha)
            Dim SenhaEncriptografada = _Algoritmo.ComputeHash(SenhaCodificar)
            Dim sb As New StringBuilder()

            For Each caracter In SenhaEncriptografada
                sb.Append(caracter.ToString("x2"))
            Next

            Return sb.ToString
        End Function

        Public Function VerificarSenha(senhaTentativa As String, senhaCadastrada As String) As Boolean

            If String.IsNullOrEmpty(senhaCadastrada) Then
                Throw New NullReferenceException("Cadastre uma senha")

            End If
            Dim SenhaEncriptografada = _Algoritmo.ComputeHash(Encoding.UTF8.GetBytes(senhaTentativa))
                Dim sb As New StringBuilder()

                For Each caracter In SenhaEncriptografada
                    sb.Append(caracter.ToString("X2"))
                Next

                Return sb.ToString = senhaCadastrada
        End Function
    End Class

End Namespace

