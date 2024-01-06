Public Class Cls_dam
    Private m_tendam As String
    Private m_b As Double
    Private m_h As Double
    Private m_l As Double
    Private m_Mmin_T As Double
    Private m_Mmax As Double
    Private m_Mmin_P As Double
    Private m_Qmax As Double
    Private m_vitri_T As Double
    Private m_vitri_G As Double
    Private m_vitri_P As Double
    Private _td1_st1, _td1_dk1, _td1_st2, _td1_dk2 As Double
    Private _td2_st1, _td2_dk1, _td2_st2, _td2_dk2 As Double
    Private _td3_st1, _td3_dk1, _td3_st2, _td3_dk2 As Double
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

    Public Property Td1_st1 As Double
        Get
            Return _td1_st1
        End Get
        Set(value As Double)
            _td1_st1 = value
        End Set
    End Property

    Public Property Td1_dk1 As Double
        Get
            Return _td1_dk1
        End Get
        Set(value As Double)
            _td1_dk1 = value
        End Set
    End Property

    Public Property Td1_st2 As Double
        Get
            Return _td1_st2
        End Get
        Set(value As Double)
            _td1_st2 = value
        End Set
    End Property

    Public Property Td1_dk2 As Double
        Get
            Return _td1_dk2
        End Get
        Set(value As Double)
            _td1_dk2 = value
        End Set
    End Property

    Public Property Td2_st1 As Double
        Get
            Return _td2_st1
        End Get
        Set(value As Double)
            _td2_st1 = value
        End Set
    End Property

    Public Property Td2_dk1 As Double
        Get
            Return _td2_dk1
        End Get
        Set(value As Double)
            _td2_dk1 = value
        End Set
    End Property

    Public Property Td2_st2 As Double
        Get
            Return _td2_st2
        End Get
        Set(value As Double)
            _td2_st2 = value
        End Set
    End Property

    Public Property Td2_dk2 As Double
        Get
            Return _td2_dk2
        End Get
        Set(value As Double)
            _td2_dk2 = value
        End Set
    End Property

    Public Property Td3_st1 As Double
        Get
            Return _td3_st1
        End Get
        Set(value As Double)
            _td3_st1 = value
        End Set
    End Property

    Public Property Td3_dk1 As Double
        Get
            Return _td3_dk1
        End Get
        Set(value As Double)
            _td3_dk1 = value
        End Set
    End Property

    Public Property Td3_st2 As Double
        Get
            Return _td3_st2
        End Get
        Set(value As Double)
            _td3_st2 = value
        End Set
    End Property

    Public Property Td3_dk2 As Double
        Get
            Return _td3_dk2
        End Get
        Set(value As Double)
            _td3_dk2 = value
        End Set
    End Property
    Public Property Vitri_T As Double
        Get
            Return m_vitri_T
        End Get
        Set(value As Double)
            m_vitri_T = value
        End Set
    End Property

    Public Property Vitri_G As Double
        Get
            Return m_vitri_G
        End Get
        Set(value As Double)
            m_vitri_G = value
        End Set
    End Property

    Public Property Vitri_P As Double
        Get
            Return m_vitri_P
        End Get
        Set(value As Double)
            m_vitri_P = value
        End Set
    End Property
End Class
