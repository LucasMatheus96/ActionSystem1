<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadastrarAtivo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CadastrarAtivo))
        Me.Btn_CadastrarRendaFixa = New System.Windows.Forms.Button()
        Me.Btn_CadastrarAcao = New System.Windows.Forms.Button()
        Me.Btn_CadastrarFI = New System.Windows.Forms.Button()
        Me.Grp_Cadastrandoativos = New System.Windows.Forms.GroupBox()
        Me.Grp_Cadastrandoativos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_CadastrarRendaFixa
        '
        Me.Btn_CadastrarRendaFixa.Location = New System.Drawing.Point(61, 58)
        Me.Btn_CadastrarRendaFixa.Name = "Btn_CadastrarRendaFixa"
        Me.Btn_CadastrarRendaFixa.Size = New System.Drawing.Size(197, 66)
        Me.Btn_CadastrarRendaFixa.TabIndex = 0
        Me.Btn_CadastrarRendaFixa.Text = "Cadastrar Renda Fixa"
        Me.Btn_CadastrarRendaFixa.UseVisualStyleBackColor = True
        '
        'Btn_CadastrarAcao
        '
        Me.Btn_CadastrarAcao.Location = New System.Drawing.Point(61, 151)
        Me.Btn_CadastrarAcao.Name = "Btn_CadastrarAcao"
        Me.Btn_CadastrarAcao.Size = New System.Drawing.Size(197, 69)
        Me.Btn_CadastrarAcao.TabIndex = 1
        Me.Btn_CadastrarAcao.Text = "Cadastrar Ações"
        Me.Btn_CadastrarAcao.UseVisualStyleBackColor = True
        '
        'Btn_CadastrarFI
        '
        Me.Btn_CadastrarFI.Location = New System.Drawing.Point(61, 250)
        Me.Btn_CadastrarFI.Name = "Btn_CadastrarFI"
        Me.Btn_CadastrarFI.Size = New System.Drawing.Size(197, 65)
        Me.Btn_CadastrarFI.TabIndex = 2
        Me.Btn_CadastrarFI.Text = "Cadastrar Fundos Imobiliarios"
        Me.Btn_CadastrarFI.UseVisualStyleBackColor = True
        '
        'Grp_Cadastrandoativos
        '
        Me.Grp_Cadastrandoativos.Controls.Add(Me.Btn_CadastrarRendaFixa)
        Me.Grp_Cadastrandoativos.Controls.Add(Me.Btn_CadastrarFI)
        Me.Grp_Cadastrandoativos.Controls.Add(Me.Btn_CadastrarAcao)
        Me.Grp_Cadastrandoativos.Location = New System.Drawing.Point(40, 33)
        Me.Grp_Cadastrandoativos.Name = "Grp_Cadastrandoativos"
        Me.Grp_Cadastrandoativos.Size = New System.Drawing.Size(317, 388)
        Me.Grp_Cadastrandoativos.TabIndex = 3
        Me.Grp_Cadastrandoativos.TabStop = False
        Me.Grp_Cadastrandoativos.Text = "Cadastrando"
        '
        'Frm_CadastrarAtivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 471)
        Me.Controls.Add(Me.Grp_Cadastrandoativos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_CadastrarAtivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_CadastrarAtivo"
        Me.Grp_Cadastrandoativos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_CadastrarRendaFixa As Button
    Friend WithEvents Btn_CadastrarAcao As Button
    Friend WithEvents Btn_CadastrarFI As Button
    Friend WithEvents Grp_Cadastrandoativos As GroupBox
End Class
