Public Class Cls_tang
    Private m_tentang As String = ""
    Private m_DanhsachDam As New List(Of Cls_dam)

    Public Property Danhsach_Dam() As List(Of Cls_dam)
        Get
            Return m_DanhsachDam
        End Get
        Set(value As List(Of Cls_dam))
            m_DanhsachDam = value
        End Set
    End Property

    Public Property TenTang As String
        Get
            Return m_tentang
        End Get
        Set(value As String)
            m_tentang = value
        End Set
    End Property
End Class
