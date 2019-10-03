/*
               File: pRegistraConsulta
        Description: Registra Consulta de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:36.13
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pregistraconsulta : GXProcedure
   {
      public pregistraconsulta( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistraconsulta( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_ConsultaId ,
                           ref DateTime aP2_ConsultaFecha ,
                           ref String aP3_ConsultaHora ,
                           ref int aP4_PacienteId ,
                           ref short aP5_ConsultaTipo ,
                           ref String aP6_AsegCodigo ,
                           ref String aP7_ConsultaObs ,
                           ref String aP8_Cie10Codigo ,
                           ref short aP9_ConsultaEdad ,
                           ref String aP10_ConsultaPoliza ,
                           ref short aP11_ConsultaEstado ,
                           ref String aP12_MedicoCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.AV8ConsultaFecha = aP2_ConsultaFecha;
         this.AV9ConsultaHora = aP3_ConsultaHora;
         this.AV10PacienteId = aP4_PacienteId;
         this.AV11ConsultaTipo = aP5_ConsultaTipo;
         this.AV12AsegCodigo = aP6_AsegCodigo;
         this.AV13ConsultaObs = aP7_ConsultaObs;
         this.AV14Cie10Codigo = aP8_Cie10Codigo;
         this.AV15ConsultaEdad = aP9_ConsultaEdad;
         this.AV16ConsultaPoliza = aP10_ConsultaPoliza;
         this.AV17ConsultaEstado = aP11_ConsultaEstado;
         this.AV18MedicoCodigo = aP12_MedicoCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_ConsultaFecha=this.AV8ConsultaFecha;
         aP3_ConsultaHora=this.AV9ConsultaHora;
         aP4_PacienteId=this.AV10PacienteId;
         aP5_ConsultaTipo=this.AV11ConsultaTipo;
         aP6_AsegCodigo=this.AV12AsegCodigo;
         aP7_ConsultaObs=this.AV13ConsultaObs;
         aP8_Cie10Codigo=this.AV14Cie10Codigo;
         aP9_ConsultaEdad=this.AV15ConsultaEdad;
         aP10_ConsultaPoliza=this.AV16ConsultaPoliza;
         aP11_ConsultaEstado=this.AV17ConsultaEstado;
         aP12_MedicoCodigo=this.AV18MedicoCodigo;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref int aP1_ConsultaId ,
                                ref DateTime aP2_ConsultaFecha ,
                                ref String aP3_ConsultaHora ,
                                ref int aP4_PacienteId ,
                                ref short aP5_ConsultaTipo ,
                                ref String aP6_AsegCodigo ,
                                ref String aP7_ConsultaObs ,
                                ref String aP8_Cie10Codigo ,
                                ref short aP9_ConsultaEdad ,
                                ref String aP10_ConsultaPoliza ,
                                ref short aP11_ConsultaEstado )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         this.AV8ConsultaFecha = aP2_ConsultaFecha;
         this.AV9ConsultaHora = aP3_ConsultaHora;
         this.AV10PacienteId = aP4_PacienteId;
         this.AV11ConsultaTipo = aP5_ConsultaTipo;
         this.AV12AsegCodigo = aP6_AsegCodigo;
         this.AV13ConsultaObs = aP7_ConsultaObs;
         this.AV14Cie10Codigo = aP8_Cie10Codigo;
         this.AV15ConsultaEdad = aP9_ConsultaEdad;
         this.AV16ConsultaPoliza = aP10_ConsultaPoliza;
         this.AV17ConsultaEstado = aP11_ConsultaEstado;
         this.AV18MedicoCodigo = aP12_MedicoCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_ConsultaFecha=this.AV8ConsultaFecha;
         aP3_ConsultaHora=this.AV9ConsultaHora;
         aP4_PacienteId=this.AV10PacienteId;
         aP5_ConsultaTipo=this.AV11ConsultaTipo;
         aP6_AsegCodigo=this.AV12AsegCodigo;
         aP7_ConsultaObs=this.AV13ConsultaObs;
         aP8_Cie10Codigo=this.AV14Cie10Codigo;
         aP9_ConsultaEdad=this.AV15ConsultaEdad;
         aP10_ConsultaPoliza=this.AV16ConsultaPoliza;
         aP11_ConsultaEstado=this.AV17ConsultaEstado;
         aP12_MedicoCodigo=this.AV18MedicoCodigo;
         return AV18MedicoCodigo ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_ConsultaId ,
                                 ref DateTime aP2_ConsultaFecha ,
                                 ref String aP3_ConsultaHora ,
                                 ref int aP4_PacienteId ,
                                 ref short aP5_ConsultaTipo ,
                                 ref String aP6_AsegCodigo ,
                                 ref String aP7_ConsultaObs ,
                                 ref String aP8_Cie10Codigo ,
                                 ref short aP9_ConsultaEdad ,
                                 ref String aP10_ConsultaPoliza ,
                                 ref short aP11_ConsultaEstado ,
                                 ref String aP12_MedicoCodigo )
      {
         pregistraconsulta objpregistraconsulta;
         objpregistraconsulta = new pregistraconsulta();
         objpregistraconsulta.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistraconsulta.A91ConsultaId = aP1_ConsultaId;
         objpregistraconsulta.AV8ConsultaFecha = aP2_ConsultaFecha;
         objpregistraconsulta.AV9ConsultaHora = aP3_ConsultaHora;
         objpregistraconsulta.AV10PacienteId = aP4_PacienteId;
         objpregistraconsulta.AV11ConsultaTipo = aP5_ConsultaTipo;
         objpregistraconsulta.AV12AsegCodigo = aP6_AsegCodigo;
         objpregistraconsulta.AV13ConsultaObs = aP7_ConsultaObs;
         objpregistraconsulta.AV14Cie10Codigo = aP8_Cie10Codigo;
         objpregistraconsulta.AV15ConsultaEdad = aP9_ConsultaEdad;
         objpregistraconsulta.AV16ConsultaPoliza = aP10_ConsultaPoliza;
         objpregistraconsulta.AV17ConsultaEstado = aP11_ConsultaEstado;
         objpregistraconsulta.AV18MedicoCodigo = aP12_MedicoCodigo;
         objpregistraconsulta.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistraconsulta);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         aP2_ConsultaFecha=this.AV8ConsultaFecha;
         aP3_ConsultaHora=this.AV9ConsultaHora;
         aP4_PacienteId=this.AV10PacienteId;
         aP5_ConsultaTipo=this.AV11ConsultaTipo;
         aP6_AsegCodigo=this.AV12AsegCodigo;
         aP7_ConsultaObs=this.AV13ConsultaObs;
         aP8_Cie10Codigo=this.AV14Cie10Codigo;
         aP9_ConsultaEdad=this.AV15ConsultaEdad;
         aP10_ConsultaPoliza=this.AV16ConsultaPoliza;
         aP11_ConsultaEstado=this.AV17ConsultaEstado;
         aP12_MedicoCodigo=this.AV18MedicoCodigo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistraconsulta)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /*
            INSERT RECORD ON TABLE Consulta

         */
         A92ConsultaFecha = AV8ConsultaFecha ;
         A93ConsultaHora = AV9ConsultaHora ;
         A67PacienteId = AV10PacienteId ;
         A94ConsultaTipo = AV11ConsultaTipo ;
         A82AsegCodigo = AV12AsegCodigo ;
         n82AsegCodigo = false ;
         A95ConsultaObs = AV13ConsultaObs ;
         A50Cie10Codigo = AV14Cie10Codigo ;
         n50Cie10Codigo = false ;
         A157ConsultaEdad = AV15ConsultaEdad ;
         A158ConsultaPoliza = AV16ConsultaPoliza ;
         A159ConsultaEstado = AV17ConsultaEstado ;
         A19MedicoCodigo = AV18MedicoCodigo ;
         n19MedicoCodigo = false ;
         if ( AV17ConsultaEstado == 2 )
         {
            A160ConsultaFechaFin = Gx_date ;
            A161ConsultaHoraFin = Gx_time ;
         }
         /* Using cursor P00062 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A91ConsultaId, A92ConsultaFecha, A93ConsultaHora, A67PacienteId, A94ConsultaTipo, n82AsegCodigo, A82AsegCodigo, A95ConsultaObs, n50Cie10Codigo, A50Cie10Codigo, A157ConsultaEdad, A158ConsultaPoliza, A159ConsultaEstado, A160ConsultaFechaFin, A161ConsultaHoraFin, n19MedicoCodigo, A19MedicoCodigo});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
            /* Using cursor P00063 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A41ClinicaCodigo = P00063_A41ClinicaCodigo[0] ;
               A91ConsultaId = P00063_A91ConsultaId[0] ;
               A94ConsultaTipo = P00063_A94ConsultaTipo[0] ;
               A82AsegCodigo = P00063_A82AsegCodigo[0] ;
               n82AsegCodigo = P00063_n82AsegCodigo[0] ;
               A95ConsultaObs = P00063_A95ConsultaObs[0] ;
               A50Cie10Codigo = P00063_A50Cie10Codigo[0] ;
               n50Cie10Codigo = P00063_n50Cie10Codigo[0] ;
               A158ConsultaPoliza = P00063_A158ConsultaPoliza[0] ;
               A159ConsultaEstado = P00063_A159ConsultaEstado[0] ;
               A160ConsultaFechaFin = P00063_A160ConsultaFechaFin[0] ;
               A161ConsultaHoraFin = P00063_A161ConsultaHoraFin[0] ;
               A94ConsultaTipo = AV11ConsultaTipo ;
               A82AsegCodigo = AV12AsegCodigo ;
               n82AsegCodigo = false ;
               A95ConsultaObs = AV13ConsultaObs ;
               A50Cie10Codigo = AV14Cie10Codigo ;
               n50Cie10Codigo = false ;
               A158ConsultaPoliza = AV16ConsultaPoliza ;
               A159ConsultaEstado = AV17ConsultaEstado ;
               if ( AV17ConsultaEstado == 2 )
               {
                  A160ConsultaFechaFin = Gx_date ;
                  A161ConsultaHoraFin = Gx_time ;
               }
               /* Using cursor P00064 */
               pr_default.execute(2, new Object[] {A94ConsultaTipo, n82AsegCodigo, A82AsegCodigo, A95ConsultaObs, n50Cie10Codigo, A50Cie10Codigo, A158ConsultaPoliza, A159ConsultaEstado, A160ConsultaFechaFin, A161ConsultaHoraFin, A41ClinicaCodigo, A91ConsultaId});
               pr_default.close(2);
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
         }
         else
         {
            context.Gx_err = 0 ;
            Gx_emsg = "" ;
         }
         /* End Insert */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pRegistraConsulta");
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         A92ConsultaFecha = DateTime.MinValue ;
         A93ConsultaHora = "" ;
         A82AsegCodigo = "" ;
         A95ConsultaObs = "" ;
         A50Cie10Codigo = "" ;
         A158ConsultaPoliza = "" ;
         A19MedicoCodigo = "" ;
         A160ConsultaFechaFin = DateTime.MinValue ;
         Gx_date = DateTime.MinValue ;
         A161ConsultaHoraFin = "" ;
         Gx_time = "" ;
         Gx_emsg = "" ;
         scmdbuf = "" ;
         P00063_A41ClinicaCodigo = new String[] {""} ;
         P00063_A91ConsultaId = new int[1] ;
         P00063_A94ConsultaTipo = new short[1] ;
         P00063_A82AsegCodigo = new String[] {""} ;
         P00063_n82AsegCodigo = new bool[] {false} ;
         P00063_A95ConsultaObs = new String[] {""} ;
         P00063_A50Cie10Codigo = new String[] {""} ;
         P00063_n50Cie10Codigo = new bool[] {false} ;
         P00063_A158ConsultaPoliza = new String[] {""} ;
         P00063_A159ConsultaEstado = new short[1] ;
         P00063_A160ConsultaFechaFin = new DateTime[] {DateTime.MinValue} ;
         P00063_A161ConsultaHoraFin = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistraconsulta__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               P00063_A41ClinicaCodigo, P00063_A91ConsultaId, P00063_A94ConsultaTipo, P00063_A82AsegCodigo, P00063_n82AsegCodigo, P00063_A95ConsultaObs, P00063_A50Cie10Codigo, P00063_n50Cie10Codigo, P00063_A158ConsultaPoliza, P00063_A159ConsultaEstado,
               P00063_A160ConsultaFechaFin, P00063_A161ConsultaHoraFin
               }
               , new Object[] {
               }
            }
         );
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short AV11ConsultaTipo ;
      private short AV15ConsultaEdad ;
      private short AV17ConsultaEstado ;
      private short A94ConsultaTipo ;
      private short A157ConsultaEdad ;
      private short A159ConsultaEstado ;
      private int A91ConsultaId ;
      private int AV10PacienteId ;
      private int GX_INS25 ;
      private int A67PacienteId ;
      private String AV9ConsultaHora ;
      private String A93ConsultaHora ;
      private String A161ConsultaHoraFin ;
      private String Gx_time ;
      private String Gx_emsg ;
      private String scmdbuf ;
      private DateTime AV8ConsultaFecha ;
      private DateTime A92ConsultaFecha ;
      private DateTime A160ConsultaFechaFin ;
      private DateTime Gx_date ;
      private bool n82AsegCodigo ;
      private bool n50Cie10Codigo ;
      private bool n19MedicoCodigo ;
      private String A41ClinicaCodigo ;
      private String AV12AsegCodigo ;
      private String AV13ConsultaObs ;
      private String AV14Cie10Codigo ;
      private String AV16ConsultaPoliza ;
      private String AV18MedicoCodigo ;
      private String A82AsegCodigo ;
      private String A95ConsultaObs ;
      private String A50Cie10Codigo ;
      private String A158ConsultaPoliza ;
      private String A19MedicoCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ConsultaId ;
      private DateTime aP2_ConsultaFecha ;
      private String aP3_ConsultaHora ;
      private int aP4_PacienteId ;
      private short aP5_ConsultaTipo ;
      private String aP6_AsegCodigo ;
      private String aP7_ConsultaObs ;
      private String aP8_Cie10Codigo ;
      private short aP9_ConsultaEdad ;
      private String aP10_ConsultaPoliza ;
      private short aP11_ConsultaEstado ;
      private String aP12_MedicoCodigo ;
      private IDataStoreProvider pr_default ;
      private String[] P00063_A41ClinicaCodigo ;
      private int[] P00063_A91ConsultaId ;
      private short[] P00063_A94ConsultaTipo ;
      private String[] P00063_A82AsegCodigo ;
      private bool[] P00063_n82AsegCodigo ;
      private String[] P00063_A95ConsultaObs ;
      private String[] P00063_A50Cie10Codigo ;
      private bool[] P00063_n50Cie10Codigo ;
      private String[] P00063_A158ConsultaPoliza ;
      private short[] P00063_A159ConsultaEstado ;
      private DateTime[] P00063_A160ConsultaFechaFin ;
      private String[] P00063_A161ConsultaHoraFin ;
   }

   public class pregistraconsulta__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00062 ;
          prmP00062 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@ConsultaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ConsultaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ConsultaTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AsegCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@Cie10Codigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ConsultaPoliza",SqlDbType.VarChar,70,0} ,
          new Object[] {"@ConsultaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ConsultaFechaFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ConsultaHoraFin",SqlDbType.Char,8,0} ,
          new Object[] {"@MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP00063 ;
          prmP00063 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP00064 ;
          prmP00064 = new Object[] {
          new Object[] {"@ConsultaTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AsegCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@Cie10Codigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaPoliza",SqlDbType.VarChar,70,0} ,
          new Object[] {"@ConsultaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ConsultaFechaFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ConsultaHoraFin",SqlDbType.Char,8,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00062", "INSERT INTO [Consulta] ([ClinicaCodigo], [ConsultaId], [ConsultaFecha], [ConsultaHora], [PacienteId], [ConsultaTipo], [AsegCodigo], [ConsultaObs], [Cie10Codigo], [ConsultaEdad], [ConsultaPoliza], [ConsultaEstado], [ConsultaFechaFin], [ConsultaHoraFin], [MedicoCodigo]) VALUES (@ClinicaCodigo, @ConsultaId, @ConsultaFecha, @ConsultaHora, @PacienteId, @ConsultaTipo, @AsegCodigo, @ConsultaObs, @Cie10Codigo, @ConsultaEdad, @ConsultaPoliza, @ConsultaEstado, @ConsultaFechaFin, @ConsultaHoraFin, @MedicoCodigo)", GxErrorMask.GX_NOMASK,prmP00062)
             ,new CursorDef("P00063", "SELECT [ClinicaCodigo], [ConsultaId], [ConsultaTipo], [AsegCodigo], [ConsultaObs], [Cie10Codigo], [ConsultaPoliza], [ConsultaEstado], [ConsultaFechaFin], [ConsultaHoraFin] FROM [Consulta] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] = @ConsultaId ORDER BY [ClinicaCodigo], [ConsultaId] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00063,1,0,true,true )
             ,new CursorDef("P00064", "UPDATE [Consulta] SET [ConsultaTipo]=@ConsultaTipo, [AsegCodigo]=@AsegCodigo, [ConsultaObs]=@ConsultaObs, [Cie10Codigo]=@Cie10Codigo, [ConsultaPoliza]=@ConsultaPoliza, [ConsultaEstado]=@ConsultaEstado, [ConsultaFechaFin]=@ConsultaFechaFin, [ConsultaHoraFin]=@ConsultaHoraFin  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [ConsultaId] = @ConsultaId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00064)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((String[]) buf[8])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[11])[0] = rslt.getString(10, 8) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                if ( (bool)parms[6] )
                {
                   stmt.setNull( 7 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(7, (String)parms[7]);
                }
                stmt.SetParameter(8, (String)parms[8]);
                if ( (bool)parms[9] )
                {
                   stmt.setNull( 9 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(9, (String)parms[10]);
                }
                stmt.SetParameter(10, (short)parms[11]);
                stmt.SetParameter(11, (String)parms[12]);
                stmt.SetParameter(12, (short)parms[13]);
                stmt.SetParameter(13, (DateTime)parms[14]);
                stmt.SetParameter(14, (String)parms[15]);
                if ( (bool)parms[16] )
                {
                   stmt.setNull( 15 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(15, (String)parms[17]);
                }
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                if ( (bool)parms[1] )
                {
                   stmt.setNull( 2 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(2, (String)parms[2]);
                }
                stmt.SetParameter(3, (String)parms[3]);
                if ( (bool)parms[4] )
                {
                   stmt.setNull( 4 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(4, (String)parms[5]);
                }
                stmt.SetParameter(5, (String)parms[6]);
                stmt.SetParameter(6, (short)parms[7]);
                stmt.SetParameter(7, (DateTime)parms[8]);
                stmt.SetParameter(8, (String)parms[9]);
                stmt.SetParameter(9, (String)parms[10]);
                stmt.SetParameter(10, (int)parms[11]);
                break;
       }
    }

 }

}
