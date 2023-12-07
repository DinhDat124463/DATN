Public Class Cls_tang
    Private m_TenDam As New List(Of Cls_dam)

    Public Property TenDam As List(Of Cls_dam)
        Get
            Return m_TenDam
        End Get
        Set(value As List(Of Cls_dam))
            m_TenDam = value
        End Set
    End Property
End Class
