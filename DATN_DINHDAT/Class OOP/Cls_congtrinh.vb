Public Class Cls_congtrinh
    Private m_danhsachtang As New List(Of Cls_tang)
    Public Property Danhsachtang() As List(Of Cls_tang)
        Get
            Return m_danhsachtang
        End Get
        Set(value As List(Of Cls_tang))
            m_danhsachtang = value
        End Set
    End Property
End Class
