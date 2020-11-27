Imports Action.classes

Public Class Frm_UsuariosCadastrados
    Dim index As Integer
    Dim objDados As New Usuario
    Dim controlUsuario As New controladorUsuario


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Consulta Usuarios"
        Btn_AlterarUsuario.Text = "Alterar"
        Btn_ExcluirUsuario.Text = "Excluir"
        Btn_voltar.Text = "Voltar"

    End Sub

    Private Sub Frm_UsuariosCadastrados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CarregarListView()
    End Sub



    Private Sub Lsw_Verusuarios_Click(sender As Object, e As EventArgs) Handles Lsw_Verusuarios.Click
        If Lsw_Verusuarios.SelectedItems.Count > 0 Then

            index = Lsw_Verusuarios.SelectedItems(0).Index

        End If
    End Sub

    Private Sub CarregarListView()
        Try
            Lsw_Verusuarios.Items.Clear()
            Dim dt As New DataTable
            dt = controlUsuario.ConsultarUsuario()

            For Each linha As DataRow In dt.Rows
                Dim lista As New ListViewItem()
                lista.Text = linha("Id").ToString()
                lista.SubItems.Add(linha("Nome").ToString())
                lista.SubItems.Add(linha("Usuario").ToString())
                lista.SubItems.Add(linha("DataDeCadastro").ToString())
                lista.SubItems.Add(linha("Permissao").ToString())

                Lsw_Verusuarios.Items.Add(lista)
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Btn_AlterarUsuario_Click(sender As Object, e As EventArgs) Handles Btn_AlterarUsuario.Click

        Try
            If Lsw_Verusuarios.Items.Count > 0 Then


                Dim AlterarCadastro As New Frm_TelaCadastro
                AlterarCadastro.IdCliente = Integer.Parse(Lsw_Verusuarios.Items(index).Text)
                AlterarCadastro.Txt_Nome.Text = Lsw_Verusuarios.Items(index).SubItems(1).Text
                AlterarCadastro.Txt_Usuario.Text = Lsw_Verusuarios.Items(index).SubItems(2).Text
                AlterarCadastro.CarregaCheckbox(Lsw_Verusuarios.Items(index).SubItems(4).Text)
                'If AlterarCadastro.classe.ChecarCampos = False Then
                '    AlterarCadastro.classe.ChecarCampos()
                'End If
                'AlterarCadastro.Txt_Senha.Text = Lsw_Verusuarios.Items(index).SubItems(3).Text
                AlterarCadastro.ShowDialog()
                Me.Close()
                CarregarListView()
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Private Sub Btn_ExcluirUsuario_Click(sender As Object, e As EventArgs) Handles Btn_ExcluirUsuario.Click
        Try
            Dim UsuarioExcluir As New Usuario

            If Lsw_Verusuarios.SelectedItems.Count > 0 Then
                controlUsuario.ExcluirUsuario(Integer.Parse(Lsw_Verusuarios.Items(index).Text))
                MsgBox("Registro Excluido com Sucesso")
                CarregarListView()

            Else
                MsgBox("Nenhum Registro Selecionado")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try

    End Sub



    Private Sub Btn_voltar_Click(sender As Object, e As EventArgs) Handles Btn_voltar.Click
        Me.Close()
    End Sub
End Class