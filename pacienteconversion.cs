/*
               File: PacienteConversion
        Description: Conversion for table Paciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:25.66
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pacienteconversion : GXProcedure
   {
      public pacienteconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public pacienteconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         pacienteconversion objpacienteconversion;
         objpacienteconversion = new pacienteconversion();
         objpacienteconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpacienteconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pacienteconversion)stateInfo).executePrivate();
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
         /* Using cursor PACIENTECO2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A144TipoPacCodigo = PACIENTECO2_A144TipoPacCodigo[0] ;
            A81PacienteEstado = PACIENTECO2_A81PacienteEstado[0] ;
            A80PacienteObs = PACIENTECO2_A80PacienteObs[0] ;
            A79PacienteDpi = PACIENTECO2_A79PacienteDpi[0] ;
            A78PacienteCorreo = PACIENTECO2_A78PacienteCorreo[0] ;
            A77PacienteTelefono2 = PACIENTECO2_A77PacienteTelefono2[0] ;
            A76PacienteTelefono1 = PACIENTECO2_A76PacienteTelefono1[0] ;
            A75PacienteDireccion = PACIENTECO2_A75PacienteDireccion[0] ;
            A74PacienteNacimiento = PACIENTECO2_A74PacienteNacimiento[0] ;
            A73PacienteGenero = PACIENTECO2_A73PacienteGenero[0] ;
            A72PacienteApellido3 = PACIENTECO2_A72PacienteApellido3[0] ;
            A71PacienteApellido2 = PACIENTECO2_A71PacienteApellido2[0] ;
            A70PacienteApellido1 = PACIENTECO2_A70PacienteApellido1[0] ;
            A69PacienteNombre2 = PACIENTECO2_A69PacienteNombre2[0] ;
            A68PacienteNombre1 = PACIENTECO2_A68PacienteNombre1[0] ;
            A67PacienteId = PACIENTECO2_A67PacienteId[0] ;
            A41ClinicaCodigo = PACIENTECO2_A41ClinicaCodigo[0] ;
            A40000GXC1 = PACIENTECO2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0023

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3PacienteId = A67PacienteId ;
            AV4PacienteNombre1 = A68PacienteNombre1 ;
            AV5PacienteNombre2 = A69PacienteNombre2 ;
            AV6PacienteApellido1 = A70PacienteApellido1 ;
            AV7PacienteApellido2 = A71PacienteApellido2 ;
            AV8PacienteApellido3 = A72PacienteApellido3 ;
            AV9PacienteGenero = A73PacienteGenero ;
            AV10PacienteNacimiento = A74PacienteNacimiento ;
            AV11PacienteDireccion = A75PacienteDireccion ;
            AV12PacienteTelefono1 = A76PacienteTelefono1 ;
            AV13PacienteTelefono2 = A77PacienteTelefono2 ;
            AV14PacienteCorreo = A78PacienteCorreo ;
            AV15PacienteDpi = A79PacienteDpi ;
            AV16PacienteObs = A80PacienteObs ;
            AV17PacienteEstado = A81PacienteEstado ;
            AV18TipoPacCodigo = A144TipoPacCodigo ;
            /* Using cursor PACIENTECO3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3PacienteId, AV4PacienteNombre1, AV5PacienteNombre2, AV6PacienteApellido1, AV7PacienteApellido2, AV8PacienteApellido3, AV9PacienteGenero, AV10PacienteNacimiento, AV11PacienteDireccion, AV12PacienteTelefono1, AV13PacienteTelefono2, AV14PacienteCorreo, AV15PacienteDpi, AV16PacienteObs, AV17PacienteEstado, AV18TipoPacCodigo});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         PACIENTECO2_A144TipoPacCodigo = new String[] {""} ;
         PACIENTECO2_A81PacienteEstado = new short[1] ;
         PACIENTECO2_A80PacienteObs = new String[] {""} ;
         PACIENTECO2_A79PacienteDpi = new String[] {""} ;
         PACIENTECO2_A78PacienteCorreo = new String[] {""} ;
         PACIENTECO2_A77PacienteTelefono2 = new String[] {""} ;
         PACIENTECO2_A76PacienteTelefono1 = new String[] {""} ;
         PACIENTECO2_A75PacienteDireccion = new String[] {""} ;
         PACIENTECO2_A74PacienteNacimiento = new DateTime[] {DateTime.MinValue} ;
         PACIENTECO2_A73PacienteGenero = new String[] {""} ;
         PACIENTECO2_A72PacienteApellido3 = new String[] {""} ;
         PACIENTECO2_A71PacienteApellido2 = new String[] {""} ;
         PACIENTECO2_A70PacienteApellido1 = new String[] {""} ;
         PACIENTECO2_A69PacienteNombre2 = new String[] {""} ;
         PACIENTECO2_A68PacienteNombre1 = new String[] {""} ;
         PACIENTECO2_A67PacienteId = new int[1] ;
         PACIENTECO2_A41ClinicaCodigo = new String[] {""} ;
         PACIENTECO2_A40000GXC1 = new int[1] ;
         A144TipoPacCodigo = "" ;
         A80PacienteObs = "" ;
         A79PacienteDpi = "" ;
         A78PacienteCorreo = "" ;
         A77PacienteTelefono2 = "" ;
         A76PacienteTelefono1 = "" ;
         A75PacienteDireccion = "" ;
         A74PacienteNacimiento = DateTime.MinValue ;
         A73PacienteGenero = "" ;
         A72PacienteApellido3 = "" ;
         A71PacienteApellido2 = "" ;
         A70PacienteApellido1 = "" ;
         A69PacienteNombre2 = "" ;
         A68PacienteNombre1 = "" ;
         A41ClinicaCodigo = "" ;
         AV4PacienteNombre1 = "" ;
         AV5PacienteNombre2 = "" ;
         AV6PacienteApellido1 = "" ;
         AV7PacienteApellido2 = "" ;
         AV8PacienteApellido3 = "" ;
         AV9PacienteGenero = "" ;
         AV10PacienteNacimiento = DateTime.MinValue ;
         AV11PacienteDireccion = "" ;
         AV12PacienteTelefono1 = "" ;
         AV13PacienteTelefono2 = "" ;
         AV14PacienteCorreo = "" ;
         AV15PacienteDpi = "" ;
         AV16PacienteObs = "" ;
         AV18TipoPacCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pacienteconversion__default(),
            new Object[][] {
                new Object[] {
               PACIENTECO2_A144TipoPacCodigo, PACIENTECO2_A81PacienteEstado, PACIENTECO2_A80PacienteObs, PACIENTECO2_A79PacienteDpi, PACIENTECO2_A78PacienteCorreo, PACIENTECO2_A77PacienteTelefono2, PACIENTECO2_A76PacienteTelefono1, PACIENTECO2_A75PacienteDireccion, PACIENTECO2_A74PacienteNacimiento, PACIENTECO2_A73PacienteGenero,
               PACIENTECO2_A72PacienteApellido3, PACIENTECO2_A71PacienteApellido2, PACIENTECO2_A70PacienteApellido1, PACIENTECO2_A69PacienteNombre2, PACIENTECO2_A68PacienteNombre1, PACIENTECO2_A67PacienteId, PACIENTECO2_A41ClinicaCodigo, PACIENTECO2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A81PacienteEstado ;
      private short AV17PacienteEstado ;
      private int A67PacienteId ;
      private int A40000GXC1 ;
      private int GIGXA0023 ;
      private int AV2ClinicaCodigo ;
      private int AV3PacienteId ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A74PacienteNacimiento ;
      private DateTime AV10PacienteNacimiento ;
      private String A144TipoPacCodigo ;
      private String A80PacienteObs ;
      private String A79PacienteDpi ;
      private String A78PacienteCorreo ;
      private String A77PacienteTelefono2 ;
      private String A76PacienteTelefono1 ;
      private String A75PacienteDireccion ;
      private String A73PacienteGenero ;
      private String A72PacienteApellido3 ;
      private String A71PacienteApellido2 ;
      private String A70PacienteApellido1 ;
      private String A69PacienteNombre2 ;
      private String A68PacienteNombre1 ;
      private String A41ClinicaCodigo ;
      private String AV4PacienteNombre1 ;
      private String AV5PacienteNombre2 ;
      private String AV6PacienteApellido1 ;
      private String AV7PacienteApellido2 ;
      private String AV8PacienteApellido3 ;
      private String AV9PacienteGenero ;
      private String AV11PacienteDireccion ;
      private String AV12PacienteTelefono1 ;
      private String AV13PacienteTelefono2 ;
      private String AV14PacienteCorreo ;
      private String AV15PacienteDpi ;
      private String AV16PacienteObs ;
      private String AV18TipoPacCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] PACIENTECO2_A144TipoPacCodigo ;
      private short[] PACIENTECO2_A81PacienteEstado ;
      private String[] PACIENTECO2_A80PacienteObs ;
      private String[] PACIENTECO2_A79PacienteDpi ;
      private String[] PACIENTECO2_A78PacienteCorreo ;
      private String[] PACIENTECO2_A77PacienteTelefono2 ;
      private String[] PACIENTECO2_A76PacienteTelefono1 ;
      private String[] PACIENTECO2_A75PacienteDireccion ;
      private DateTime[] PACIENTECO2_A74PacienteNacimiento ;
      private String[] PACIENTECO2_A73PacienteGenero ;
      private String[] PACIENTECO2_A72PacienteApellido3 ;
      private String[] PACIENTECO2_A71PacienteApellido2 ;
      private String[] PACIENTECO2_A70PacienteApellido1 ;
      private String[] PACIENTECO2_A69PacienteNombre2 ;
      private String[] PACIENTECO2_A68PacienteNombre1 ;
      private int[] PACIENTECO2_A67PacienteId ;
      private String[] PACIENTECO2_A41ClinicaCodigo ;
      private int[] PACIENTECO2_A40000GXC1 ;
   }

   public class pacienteconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmPACIENTECO2 ;
          prmPACIENTECO2 = new Object[] {
          } ;
          Object[] prmPACIENTECO3 ;
          prmPACIENTECO3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4PacienteNombre1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV5PacienteNombre2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV6PacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV7PacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV8PacienteApellido3",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV9PacienteGenero",SqlDbType.VarChar,1,0} ,
          new Object[] {"@AV10PacienteNacimiento",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV11PacienteDireccion",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV12PacienteTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV13PacienteTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV14PacienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV15PacienteDpi",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV16PacienteObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV17PacienteEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV18TipoPacCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("PACIENTECO2", "SELECT [TipoPacCodigo], [PacienteEstado], [PacienteObs], [PacienteDpi], [PacienteCorreo], [PacienteTelefono2], [PacienteTelefono1], [PacienteDireccion], [PacienteNacimiento], [PacienteGenero], [PacienteApellido3], [PacienteApellido2], [PacienteApellido1], [PacienteNombre2], [PacienteNombre1], [PacienteId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Paciente] ORDER BY [ClinicaCodigo], [PacienteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmPACIENTECO2,100,0,true,false )
             ,new CursorDef("PACIENTECO3", "INSERT INTO [GXA0023] ([ClinicaCodigo], [PacienteId], [PacienteNombre1], [PacienteNombre2], [PacienteApellido1], [PacienteApellido2], [PacienteApellido3], [PacienteGenero], [PacienteNacimiento], [PacienteDireccion], [PacienteTelefono1], [PacienteTelefono2], [PacienteCorreo], [PacienteDpi], [PacienteObs], [PacienteEstado], [TipoPacCodigo]) VALUES (@AV2ClinicaCodigo, @AV3PacienteId, @AV4PacienteNombre1, @AV5PacienteNombre2, @AV6PacienteApellido1, @AV7PacienteApellido2, @AV8PacienteApellido3, @AV9PacienteGenero, @AV10PacienteNacimiento, @AV11PacienteDireccion, @AV12PacienteTelefono1, @AV13PacienteTelefono2, @AV14PacienteCorreo, @AV15PacienteDpi, @AV16PacienteObs, @AV17PacienteEstado, @AV18TipoPacCodigo)", GxErrorMask.GX_NOMASK,prmPACIENTECO3)
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((int[]) buf[15])[0] = rslt.getInt(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((int[]) buf[17])[0] = rslt.getInt(18) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (DateTime)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (short)parms[15]);
                stmt.SetParameter(17, (String)parms[16]);
                break;
       }
    }

 }

}
