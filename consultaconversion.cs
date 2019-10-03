/*
               File: ConsultaConversion
        Description: Conversion for table Consulta
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:24.11
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
   public class consultaconversion : GXProcedure
   {
      public consultaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public consultaconversion( IGxContext context )
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
         consultaconversion objconsultaconversion;
         objconsultaconversion = new consultaconversion();
         objconsultaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objconsultaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((consultaconversion)stateInfo).executePrivate();
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
         /* Using cursor CONSULTACO2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A19MedicoCodigo = CONSULTACO2_A19MedicoCodigo[0] ;
            n19MedicoCodigo = CONSULTACO2_n19MedicoCodigo[0] ;
            A161ConsultaHoraFin = CONSULTACO2_A161ConsultaHoraFin[0] ;
            A160ConsultaFechaFin = CONSULTACO2_A160ConsultaFechaFin[0] ;
            A159ConsultaEstado = CONSULTACO2_A159ConsultaEstado[0] ;
            A158ConsultaPoliza = CONSULTACO2_A158ConsultaPoliza[0] ;
            A157ConsultaEdad = CONSULTACO2_A157ConsultaEdad[0] ;
            A50Cie10Codigo = CONSULTACO2_A50Cie10Codigo[0] ;
            n50Cie10Codigo = CONSULTACO2_n50Cie10Codigo[0] ;
            A95ConsultaObs = CONSULTACO2_A95ConsultaObs[0] ;
            A82AsegCodigo = CONSULTACO2_A82AsegCodigo[0] ;
            n82AsegCodigo = CONSULTACO2_n82AsegCodigo[0] ;
            A94ConsultaTipo = CONSULTACO2_A94ConsultaTipo[0] ;
            A67PacienteId = CONSULTACO2_A67PacienteId[0] ;
            A93ConsultaHora = CONSULTACO2_A93ConsultaHora[0] ;
            A92ConsultaFecha = CONSULTACO2_A92ConsultaFecha[0] ;
            A91ConsultaId = CONSULTACO2_A91ConsultaId[0] ;
            A41ClinicaCodigo = CONSULTACO2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CONSULTACO2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0025

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3ConsultaId = A91ConsultaId ;
            AV4ConsultaFecha = A92ConsultaFecha ;
            AV5ConsultaHora = A93ConsultaHora ;
            AV6PacienteId = A67PacienteId ;
            AV7ConsultaTipo = A94ConsultaTipo ;
            if ( CONSULTACO2_n82AsegCodigo[0] )
            {
               AV8AsegCodigo = "" ;
               nV8AsegCodigo = false ;
               nV8AsegCodigo = true ;
            }
            else
            {
               AV8AsegCodigo = A82AsegCodigo ;
               nV8AsegCodigo = false ;
            }
            AV9ConsultaObs = A95ConsultaObs ;
            if ( CONSULTACO2_n50Cie10Codigo[0] )
            {
               AV10Cie10Codigo = "" ;
               nV10Cie10Codigo = false ;
               nV10Cie10Codigo = true ;
            }
            else
            {
               AV10Cie10Codigo = A50Cie10Codigo ;
               nV10Cie10Codigo = false ;
            }
            AV11ConsultaEdad = A157ConsultaEdad ;
            AV12ConsultaPoliza = A158ConsultaPoliza ;
            AV13ConsultaEstado = A159ConsultaEstado ;
            AV14ConsultaFechaFin = A160ConsultaFechaFin ;
            AV15ConsultaHoraFin = A161ConsultaHoraFin ;
            if ( CONSULTACO2_n19MedicoCodigo[0] )
            {
               AV16MedicoCodigo = "" ;
               nV16MedicoCodigo = false ;
               nV16MedicoCodigo = true ;
            }
            else
            {
               AV16MedicoCodigo = A19MedicoCodigo ;
               nV16MedicoCodigo = false ;
            }
            /* Using cursor CONSULTACO3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3ConsultaId, AV4ConsultaFecha, AV5ConsultaHora, AV6PacienteId, AV7ConsultaTipo, nV8AsegCodigo, AV8AsegCodigo, AV9ConsultaObs, nV10Cie10Codigo, AV10Cie10Codigo, AV11ConsultaEdad, AV12ConsultaPoliza, AV13ConsultaEstado, AV14ConsultaFechaFin, AV15ConsultaHoraFin, nV16MedicoCodigo, AV16MedicoCodigo});
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
         CONSULTACO2_A19MedicoCodigo = new String[] {""} ;
         CONSULTACO2_n19MedicoCodigo = new bool[] {false} ;
         CONSULTACO2_A161ConsultaHoraFin = new String[] {""} ;
         CONSULTACO2_A160ConsultaFechaFin = new DateTime[] {DateTime.MinValue} ;
         CONSULTACO2_A159ConsultaEstado = new short[1] ;
         CONSULTACO2_A158ConsultaPoliza = new String[] {""} ;
         CONSULTACO2_A157ConsultaEdad = new short[1] ;
         CONSULTACO2_A50Cie10Codigo = new String[] {""} ;
         CONSULTACO2_n50Cie10Codigo = new bool[] {false} ;
         CONSULTACO2_A95ConsultaObs = new String[] {""} ;
         CONSULTACO2_A82AsegCodigo = new String[] {""} ;
         CONSULTACO2_n82AsegCodigo = new bool[] {false} ;
         CONSULTACO2_A94ConsultaTipo = new short[1] ;
         CONSULTACO2_A67PacienteId = new int[1] ;
         CONSULTACO2_A93ConsultaHora = new String[] {""} ;
         CONSULTACO2_A92ConsultaFecha = new DateTime[] {DateTime.MinValue} ;
         CONSULTACO2_A91ConsultaId = new int[1] ;
         CONSULTACO2_A41ClinicaCodigo = new String[] {""} ;
         CONSULTACO2_A40000GXC1 = new int[1] ;
         A19MedicoCodigo = "" ;
         A161ConsultaHoraFin = "" ;
         A160ConsultaFechaFin = DateTime.MinValue ;
         A158ConsultaPoliza = "" ;
         A50Cie10Codigo = "" ;
         A95ConsultaObs = "" ;
         A82AsegCodigo = "" ;
         A93ConsultaHora = "" ;
         A92ConsultaFecha = DateTime.MinValue ;
         A41ClinicaCodigo = "" ;
         AV4ConsultaFecha = DateTime.MinValue ;
         AV5ConsultaHora = "" ;
         AV8AsegCodigo = "" ;
         AV9ConsultaObs = "" ;
         AV10Cie10Codigo = "" ;
         AV12ConsultaPoliza = "" ;
         AV14ConsultaFechaFin = DateTime.MinValue ;
         AV15ConsultaHoraFin = "" ;
         AV16MedicoCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.consultaconversion__default(),
            new Object[][] {
                new Object[] {
               CONSULTACO2_A19MedicoCodigo, CONSULTACO2_n19MedicoCodigo, CONSULTACO2_A161ConsultaHoraFin, CONSULTACO2_A160ConsultaFechaFin, CONSULTACO2_A159ConsultaEstado, CONSULTACO2_A158ConsultaPoliza, CONSULTACO2_A157ConsultaEdad, CONSULTACO2_A50Cie10Codigo, CONSULTACO2_n50Cie10Codigo, CONSULTACO2_A95ConsultaObs,
               CONSULTACO2_A82AsegCodigo, CONSULTACO2_n82AsegCodigo, CONSULTACO2_A94ConsultaTipo, CONSULTACO2_A67PacienteId, CONSULTACO2_A93ConsultaHora, CONSULTACO2_A92ConsultaFecha, CONSULTACO2_A91ConsultaId, CONSULTACO2_A41ClinicaCodigo, CONSULTACO2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A159ConsultaEstado ;
      private short A157ConsultaEdad ;
      private short A94ConsultaTipo ;
      private short AV7ConsultaTipo ;
      private short AV11ConsultaEdad ;
      private short AV13ConsultaEstado ;
      private int A67PacienteId ;
      private int A91ConsultaId ;
      private int A40000GXC1 ;
      private int GIGXA0025 ;
      private int AV2ClinicaCodigo ;
      private int AV3ConsultaId ;
      private int AV6PacienteId ;
      private String scmdbuf ;
      private String A161ConsultaHoraFin ;
      private String A93ConsultaHora ;
      private String AV5ConsultaHora ;
      private String AV15ConsultaHoraFin ;
      private String Gx_emsg ;
      private DateTime A160ConsultaFechaFin ;
      private DateTime A92ConsultaFecha ;
      private DateTime AV4ConsultaFecha ;
      private DateTime AV14ConsultaFechaFin ;
      private bool n19MedicoCodigo ;
      private bool n50Cie10Codigo ;
      private bool n82AsegCodigo ;
      private bool nV8AsegCodigo ;
      private bool nV10Cie10Codigo ;
      private bool nV16MedicoCodigo ;
      private String A19MedicoCodigo ;
      private String A158ConsultaPoliza ;
      private String A50Cie10Codigo ;
      private String A95ConsultaObs ;
      private String A82AsegCodigo ;
      private String A41ClinicaCodigo ;
      private String AV8AsegCodigo ;
      private String AV9ConsultaObs ;
      private String AV10Cie10Codigo ;
      private String AV12ConsultaPoliza ;
      private String AV16MedicoCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] CONSULTACO2_A19MedicoCodigo ;
      private bool[] CONSULTACO2_n19MedicoCodigo ;
      private String[] CONSULTACO2_A161ConsultaHoraFin ;
      private DateTime[] CONSULTACO2_A160ConsultaFechaFin ;
      private short[] CONSULTACO2_A159ConsultaEstado ;
      private String[] CONSULTACO2_A158ConsultaPoliza ;
      private short[] CONSULTACO2_A157ConsultaEdad ;
      private String[] CONSULTACO2_A50Cie10Codigo ;
      private bool[] CONSULTACO2_n50Cie10Codigo ;
      private String[] CONSULTACO2_A95ConsultaObs ;
      private String[] CONSULTACO2_A82AsegCodigo ;
      private bool[] CONSULTACO2_n82AsegCodigo ;
      private short[] CONSULTACO2_A94ConsultaTipo ;
      private int[] CONSULTACO2_A67PacienteId ;
      private String[] CONSULTACO2_A93ConsultaHora ;
      private DateTime[] CONSULTACO2_A92ConsultaFecha ;
      private int[] CONSULTACO2_A91ConsultaId ;
      private String[] CONSULTACO2_A41ClinicaCodigo ;
      private int[] CONSULTACO2_A40000GXC1 ;
   }

   public class consultaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCONSULTACO2 ;
          prmCONSULTACO2 = new Object[] {
          } ;
          Object[] prmCONSULTACO3 ;
          prmCONSULTACO3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4ConsultaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV5ConsultaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV6PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV7ConsultaTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV8AsegCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV9ConsultaObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV10Cie10Codigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11ConsultaEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12ConsultaPoliza",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV13ConsultaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV14ConsultaFechaFin",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV15ConsultaHoraFin",SqlDbType.Char,8,0} ,
          new Object[] {"@AV16MedicoCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CONSULTACO2", "SELECT [MedicoCodigo], [ConsultaHoraFin], [ConsultaFechaFin], [ConsultaEstado], [ConsultaPoliza], [ConsultaEdad], [Cie10Codigo], [ConsultaObs], [AsegCodigo], [ConsultaTipo], [PacienteId], [ConsultaHora], [ConsultaFecha], [ConsultaId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Consulta] ORDER BY [ClinicaCodigo], [ConsultaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCONSULTACO2,100,0,true,false )
             ,new CursorDef("CONSULTACO3", "INSERT INTO [GXA0025] ([ClinicaCodigo], [ConsultaId], [ConsultaFecha], [ConsultaHora], [PacienteId], [ConsultaTipo], [AsegCodigo], [ConsultaObs], [Cie10Codigo], [ConsultaEdad], [ConsultaPoliza], [ConsultaEstado], [ConsultaFechaFin], [ConsultaHoraFin], [MedicoCodigo]) VALUES (@AV2ClinicaCodigo, @AV3ConsultaId, @AV4ConsultaFecha, @AV5ConsultaHora, @AV6PacienteId, @AV7ConsultaTipo, @AV8AsegCodigo, @AV9ConsultaObs, @AV10Cie10Codigo, @AV11ConsultaEdad, @AV12ConsultaPoliza, @AV13ConsultaEstado, @AV14ConsultaFechaFin, @AV15ConsultaHoraFin, @AV16MedicoCodigo)", GxErrorMask.GX_NOMASK,prmCONSULTACO3)
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 8) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[6])[0] = rslt.getShort(6) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(7);
                ((String[]) buf[9])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(9);
                ((short[]) buf[12])[0] = rslt.getShort(10) ;
                ((int[]) buf[13])[0] = rslt.getInt(11) ;
                ((String[]) buf[14])[0] = rslt.getString(12, 8) ;
                ((DateTime[]) buf[15])[0] = rslt.getGXDate(13) ;
                ((int[]) buf[16])[0] = rslt.getInt(14) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(15) ;
                ((int[]) buf[18])[0] = rslt.getInt(16) ;
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
       }
    }

 }

}
