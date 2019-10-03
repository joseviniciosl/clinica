/*
               File: pObtieneInfoPaciente
        Description: Obtiene Información de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:34.86
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
   public class pobtieneinfopaciente : GXProcedure
   {
      public pobtieneinfopaciente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pobtieneinfopaciente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_PacienteId ,
                           ref String aP2_PacienteNombre1 ,
                           ref String aP3_PacienteNombre2 ,
                           ref String aP4_PacienteApellido1 ,
                           ref String aP5_PacienteApellido2 ,
                           ref String aP6_PacienteApellido3 ,
                           ref String aP7_PacienteSexo ,
                           ref DateTime aP8_PacienteNacimiento ,
                           ref short aP9_ConsultaEdad )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A67PacienteId = aP1_PacienteId;
         this.AV8PacienteNombre1 = aP2_PacienteNombre1;
         this.AV9PacienteNombre2 = aP3_PacienteNombre2;
         this.AV10PacienteApellido1 = aP4_PacienteApellido1;
         this.AV11PacienteApellido2 = aP5_PacienteApellido2;
         this.AV12PacienteApellido3 = aP6_PacienteApellido3;
         this.AV14PacienteSexo = aP7_PacienteSexo;
         this.AV13PacienteNacimiento = aP8_PacienteNacimiento;
         this.AV15ConsultaEdad = aP9_ConsultaEdad;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_PacienteId=this.A67PacienteId;
         aP2_PacienteNombre1=this.AV8PacienteNombre1;
         aP3_PacienteNombre2=this.AV9PacienteNombre2;
         aP4_PacienteApellido1=this.AV10PacienteApellido1;
         aP5_PacienteApellido2=this.AV11PacienteApellido2;
         aP6_PacienteApellido3=this.AV12PacienteApellido3;
         aP7_PacienteSexo=this.AV14PacienteSexo;
         aP8_PacienteNacimiento=this.AV13PacienteNacimiento;
         aP9_ConsultaEdad=this.AV15ConsultaEdad;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref int aP1_PacienteId ,
                               ref String aP2_PacienteNombre1 ,
                               ref String aP3_PacienteNombre2 ,
                               ref String aP4_PacienteApellido1 ,
                               ref String aP5_PacienteApellido2 ,
                               ref String aP6_PacienteApellido3 ,
                               ref String aP7_PacienteSexo ,
                               ref DateTime aP8_PacienteNacimiento )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A67PacienteId = aP1_PacienteId;
         this.AV8PacienteNombre1 = aP2_PacienteNombre1;
         this.AV9PacienteNombre2 = aP3_PacienteNombre2;
         this.AV10PacienteApellido1 = aP4_PacienteApellido1;
         this.AV11PacienteApellido2 = aP5_PacienteApellido2;
         this.AV12PacienteApellido3 = aP6_PacienteApellido3;
         this.AV14PacienteSexo = aP7_PacienteSexo;
         this.AV13PacienteNacimiento = aP8_PacienteNacimiento;
         this.AV15ConsultaEdad = aP9_ConsultaEdad;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_PacienteId=this.A67PacienteId;
         aP2_PacienteNombre1=this.AV8PacienteNombre1;
         aP3_PacienteNombre2=this.AV9PacienteNombre2;
         aP4_PacienteApellido1=this.AV10PacienteApellido1;
         aP5_PacienteApellido2=this.AV11PacienteApellido2;
         aP6_PacienteApellido3=this.AV12PacienteApellido3;
         aP7_PacienteSexo=this.AV14PacienteSexo;
         aP8_PacienteNacimiento=this.AV13PacienteNacimiento;
         aP9_ConsultaEdad=this.AV15ConsultaEdad;
         return AV15ConsultaEdad ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_PacienteId ,
                                 ref String aP2_PacienteNombre1 ,
                                 ref String aP3_PacienteNombre2 ,
                                 ref String aP4_PacienteApellido1 ,
                                 ref String aP5_PacienteApellido2 ,
                                 ref String aP6_PacienteApellido3 ,
                                 ref String aP7_PacienteSexo ,
                                 ref DateTime aP8_PacienteNacimiento ,
                                 ref short aP9_ConsultaEdad )
      {
         pobtieneinfopaciente objpobtieneinfopaciente;
         objpobtieneinfopaciente = new pobtieneinfopaciente();
         objpobtieneinfopaciente.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpobtieneinfopaciente.A67PacienteId = aP1_PacienteId;
         objpobtieneinfopaciente.AV8PacienteNombre1 = aP2_PacienteNombre1;
         objpobtieneinfopaciente.AV9PacienteNombre2 = aP3_PacienteNombre2;
         objpobtieneinfopaciente.AV10PacienteApellido1 = aP4_PacienteApellido1;
         objpobtieneinfopaciente.AV11PacienteApellido2 = aP5_PacienteApellido2;
         objpobtieneinfopaciente.AV12PacienteApellido3 = aP6_PacienteApellido3;
         objpobtieneinfopaciente.AV14PacienteSexo = aP7_PacienteSexo;
         objpobtieneinfopaciente.AV13PacienteNacimiento = aP8_PacienteNacimiento;
         objpobtieneinfopaciente.AV15ConsultaEdad = aP9_ConsultaEdad;
         objpobtieneinfopaciente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpobtieneinfopaciente);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_PacienteId=this.A67PacienteId;
         aP2_PacienteNombre1=this.AV8PacienteNombre1;
         aP3_PacienteNombre2=this.AV9PacienteNombre2;
         aP4_PacienteApellido1=this.AV10PacienteApellido1;
         aP5_PacienteApellido2=this.AV11PacienteApellido2;
         aP6_PacienteApellido3=this.AV12PacienteApellido3;
         aP7_PacienteSexo=this.AV14PacienteSexo;
         aP8_PacienteNacimiento=this.AV13PacienteNacimiento;
         aP9_ConsultaEdad=this.AV15ConsultaEdad;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pobtieneinfopaciente)stateInfo).executePrivate();
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
         /* Using cursor P00042 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A67PacienteId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A68PacienteNombre1 = P00042_A68PacienteNombre1[0] ;
            A69PacienteNombre2 = P00042_A69PacienteNombre2[0] ;
            A70PacienteApellido1 = P00042_A70PacienteApellido1[0] ;
            A71PacienteApellido2 = P00042_A71PacienteApellido2[0] ;
            A72PacienteApellido3 = P00042_A72PacienteApellido3[0] ;
            A74PacienteNacimiento = P00042_A74PacienteNacimiento[0] ;
            A326PacienteSexo = P00042_A326PacienteSexo[0] ;
            AV8PacienteNombre1 = A68PacienteNombre1 ;
            AV9PacienteNombre2 = A69PacienteNombre2 ;
            AV10PacienteApellido1 = A70PacienteApellido1 ;
            AV11PacienteApellido2 = A71PacienteApellido2 ;
            AV12PacienteApellido3 = A72PacienteApellido3 ;
            AV13PacienteNacimiento = A74PacienteNacimiento ;
            AV14PacienteSexo = A326PacienteSexo ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         AV15ConsultaEdad = (short)(DateTimeUtil.Year( Gx_date)-DateTimeUtil.Year( AV13PacienteNacimiento)) ;
         this.cleanup();
      }

      protected void cleanup( )
      {
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
         scmdbuf = "" ;
         P00042_A41ClinicaCodigo = new String[] {""} ;
         P00042_A67PacienteId = new int[1] ;
         P00042_A68PacienteNombre1 = new String[] {""} ;
         P00042_A69PacienteNombre2 = new String[] {""} ;
         P00042_A70PacienteApellido1 = new String[] {""} ;
         P00042_A71PacienteApellido2 = new String[] {""} ;
         P00042_A72PacienteApellido3 = new String[] {""} ;
         P00042_A74PacienteNacimiento = new DateTime[] {DateTime.MinValue} ;
         P00042_A326PacienteSexo = new String[] {""} ;
         A68PacienteNombre1 = "" ;
         A69PacienteNombre2 = "" ;
         A70PacienteApellido1 = "" ;
         A71PacienteApellido2 = "" ;
         A72PacienteApellido3 = "" ;
         A74PacienteNacimiento = DateTime.MinValue ;
         A326PacienteSexo = "" ;
         Gx_date = DateTime.MinValue ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pobtieneinfopaciente__default(),
            new Object[][] {
                new Object[] {
               P00042_A41ClinicaCodigo, P00042_A67PacienteId, P00042_A68PacienteNombre1, P00042_A69PacienteNombre2, P00042_A70PacienteApellido1, P00042_A71PacienteApellido2, P00042_A72PacienteApellido3, P00042_A74PacienteNacimiento, P00042_A326PacienteSexo
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short AV15ConsultaEdad ;
      private int A67PacienteId ;
      private String scmdbuf ;
      private DateTime AV13PacienteNacimiento ;
      private DateTime A74PacienteNacimiento ;
      private DateTime Gx_date ;
      private String A41ClinicaCodigo ;
      private String AV8PacienteNombre1 ;
      private String AV9PacienteNombre2 ;
      private String AV10PacienteApellido1 ;
      private String AV11PacienteApellido2 ;
      private String AV12PacienteApellido3 ;
      private String AV14PacienteSexo ;
      private String A68PacienteNombre1 ;
      private String A69PacienteNombre2 ;
      private String A70PacienteApellido1 ;
      private String A71PacienteApellido2 ;
      private String A72PacienteApellido3 ;
      private String A326PacienteSexo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_PacienteId ;
      private String aP2_PacienteNombre1 ;
      private String aP3_PacienteNombre2 ;
      private String aP4_PacienteApellido1 ;
      private String aP5_PacienteApellido2 ;
      private String aP6_PacienteApellido3 ;
      private String aP7_PacienteSexo ;
      private DateTime aP8_PacienteNacimiento ;
      private short aP9_ConsultaEdad ;
      private IDataStoreProvider pr_default ;
      private String[] P00042_A41ClinicaCodigo ;
      private int[] P00042_A67PacienteId ;
      private String[] P00042_A68PacienteNombre1 ;
      private String[] P00042_A69PacienteNombre2 ;
      private String[] P00042_A70PacienteApellido1 ;
      private String[] P00042_A71PacienteApellido2 ;
      private String[] P00042_A72PacienteApellido3 ;
      private DateTime[] P00042_A74PacienteNacimiento ;
      private String[] P00042_A326PacienteSexo ;
   }

   public class pobtieneinfopaciente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00042 ;
          prmP00042 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00042", "SELECT [ClinicaCodigo], [PacienteId], [PacienteNombre1], [PacienteNombre2], [PacienteApellido1], [PacienteApellido2], [PacienteApellido3], [PacienteNacimiento], [PacienteSexo] FROM [Paciente] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [PacienteId] = @PacienteId ORDER BY [ClinicaCodigo], [PacienteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00042,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
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
                break;
       }
    }

 }

}
