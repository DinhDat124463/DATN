Public Class Cls_dam
    Private m_tendam As String
    Private m_b As Double
    Private m_h As Double
    Private m_l As Double
    Private m_Mmin_T As Double
    Private m_Mmax As Double
    Private m_Mmin_P As Double
    Private m_Qmax As Double

    Public Property Tendam As String
        Get
            Return m_tendam
        End Get
        Set(value As String)
            m_tendam = value
        End Set
    End Property

    Public Property B As Double
        Get
            Return m_b
        End Get
        Set(value As Double)
            m_b = value
        End Set
    End Property

    Public Property H As Double
        Get
            Return m_h
        End Get
        Set(value As Double)
            m_h = value
        End Set
    End Property

    Public Property L As Double
        Get
            Return m_l
        End Get
        Set(value As Double)
            m_l = value
        End Set
    End Property

    Public Property Mmax As Double
        Get
            Return m_Mmax
        End Get
        Set(value As Double)
            m_Mmax = value
        End Set
    End Property

    Public Property Qmax As Double
        Get
            Return m_Qmax
        End Get
        Set(value As Double)
            m_Qmax = value
        End Set
    End Property


    Public Property Mmin_T As Double
        Get
            Return m_Mmin_T
        End Get
        Set(value As Double)
            m_Mmin_T = value
        End Set
    End Property

    Public Property Mmin_P As Double
        Get
            Return m_Mmin_P
        End Get
        Set(value As Double)
            m_Mmin_P = value
        End Set
    End Property
End Class
