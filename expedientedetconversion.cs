/*
               File: ExpedienteDetConversion
        Description: Conversion for table ExpedienteDet
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:25.8
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
   public class expedientedetconversion : GXProcedure
   {
      public expedientedetconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public expedientedetconversion( IGxContext context )
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
         expedientedetconversion objexpedientedetconversion;
         objexpedientedetconversion = new expedientedetconversion();
         objexpedientedetconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objexpedientedetconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((expedientedetconversion)stateInfo).executePrivate();
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
         /* Using cursor EXPEDIENTE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A175UsuarioCodigoL = EXPEDIENTE2_A175UsuarioCodigoL[0] ;
            A174ExpedienteHoraL = EXPEDIENTE2_A174ExpedienteHoraL[0] ;
            A173ExpedienteFechaL = EXPEDIENTE2_A173ExpedienteFechaL[0] ;
            A172ExpedienteDescripcion = EXPEDIENTE2_A172ExpedienteDescripcion[0] ;
            A170ExpedienteLinea = EXPEDIENTE2_A170ExpedienteLinea[0] ;
            A167ExpedienteId = EXPEDIENTE2_A167ExpedienteId[0] ;
            A41ClinicaCodigo = EXPEDIENTE2_A41ClinicaCodigo[0] ;
            A40000GXC1 = EXPEDIENTE2_A40000GXC1[0] ;
            A171ExpedienteArchivo = EXPEDIENTE2_A171ExpedienteArchivo[0] ;
            /*
               INSERT RECORD ON TABLE GXA0047

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3ExpedienteId = A167ExpedienteId ;
            AV4ExpedienteLinea = A170ExpedienteLinea ;
            AV5ExpedienteArchivo = A171ExpedienteArchivo ;
            AV6ExpedienteDescripcion = A172ExpedienteDescripcion ;
            AV7ExpedienteFechaL = A173ExpedienteFechaL ;
            AV8ExpedienteHoraL = A174ExpedienteHoraL ;
            AV9UsuarioCodigoL = A175UsuarioCodigoL ;
            /* Using cursor EXPEDIENTE3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3ExpedienteId, AV4ExpedienteLinea, AV5ExpedienteArchivo, AV6ExpedienteDescripcion, AV7ExpedienteFechaL, AV8ExpedienteHoraL, AV9UsuarioCodigoL});
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
         EXPEDIENTE2_A175UsuarioCodigoL = new String[] {""} ;
         EXPEDIENTE2_A174ExpedienteHoraL = new String[] {""} ;
         EXPEDIENTE2_A173ExpedienteFechaL = new DateTime[] {DateTime.MinValue} ;
         EXPEDIENTE2_A172ExpedienteDescripcion = new String[] {""} ;
         EXPEDIENTE2_A170ExpedienteLinea = new short[1] ;
         EXPEDIENTE2_A167ExpedienteId = new int[1] ;
         EXPEDIENTE2_A41ClinicaCodigo = new String[] {""} ;
         EXPEDIENTE2_A40000GXC1 = new int[1] ;
         EXPEDIENTE2_A171ExpedienteArchivo = new String[] {""} ;
         A175UsuarioCodigoL = "" ;
         A174ExpedienteHoraL = "" ;
         A173ExpedienteFechaL = DateTime.MinValue ;
         A172ExpedienteDescripcion = "" ;
         A41ClinicaCodigo = "" ;
         A171ExpedienteArchivo = "" ;
         AV5ExpedienteArchivo = "" ;
         AV6ExpedienteDescripcion = "" ;
         AV7ExpedienteFechaL = DateTime.MinValue ;
         AV8ExpedienteHoraL = "" ;
         AV9UsuarioCodigoL = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.expedientedetconversion__default(),
            new Object[][] {
                new Object[] {
               EXPEDIENTE2_A175UsuarioCodigoL, EXPEDIENTE2_A174ExpedienteHoraL, EXPEDIENTE2_A173ExpedienteFechaL, EXPEDIENTE2_A172ExpedienteDescripcion, EXPEDIENTE2_A170ExpedienteLinea, EXPEDIENTE2_A167ExpedienteId, EXPEDIENTE2_A41ClinicaCodigo, EXPEDIENTE2_A40000GXC1, EXPEDIENTE2_A171ExpedienteArchivo
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A170ExpedienteLinea ;
      private short AV4ExpedienteLinea ;
      private int A167ExpedienteId ;
      private int A40000GXC1 ;
      private int GIGXA0047 ;
      private int AV2ClinicaCodigo ;
      private int AV3ExpedienteId ;
      private String scmdbuf ;
      private String A174ExpedienteHoraL ;
      private String AV8ExpedienteHoraL ;
      private String Gx_emsg ;
      private DateTime A173ExpedienteFechaL ;
      private DateTime AV7ExpedienteFechaL ;
      private String A175UsuarioCodigoL ;
      private String A172ExpedienteDescripcion ;
      private String A41ClinicaCodigo ;
      private String AV6ExpedienteDescripcion ;
      private String AV9UsuarioCodigoL ;
      private String A171ExpedienteArchivo ;
      private String AV5ExpedienteArchivo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] EXPEDIENTE2_A175UsuarioCodigoL ;
      private String[] EXPEDIENTE2_A174ExpedienteHoraL ;
      private DateTime[] EXPEDIENTE2_A173ExpedienteFechaL ;
      private String[] EXPEDIENTE2_A172ExpedienteDescripcion ;
      private short[] EXPEDIENTE2_A170ExpedienteLinea ;
      private int[] EXPEDIENTE2_A167ExpedienteId ;
      private String[] EXPEDIENTE2_A41ClinicaCodigo ;
      private int[] EXPEDIENTE2_A40000GXC1 ;
      private String[] EXPEDIENTE2_A171ExpedienteArchivo ;
   }

   public class expedientedetconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmEXPEDIENTE2 ;
          prmEXPEDIENTE2 = new Object[] {
          } ;
          Object[] prmEXPEDIENTE3 ;
          prmEXPEDIENTE3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4ExpedienteLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5ExpedienteArchivo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@AV6ExpedienteDescripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV7ExpedienteFechaL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8ExpedienteHoraL",SqlDbType.Char,8,0} ,
          new Object[] {"@AV9UsuarioCodigoL",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("EXPEDIENTE2", "SELECT [UsuarioCodigoL], [ExpedienteHoraL], [ExpedienteFechaL], [ExpedienteDescripcion], [ExpedienteLinea], [ExpedienteId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1, [ExpedienteArchivo] FROM [ExpedienteDet] ORDER BY [ClinicaCodigo], [ExpedienteId], [ExpedienteLinea] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmEXPEDIENTE2,1,0,true,false )
             ,new CursorDef("EXPEDIENTE3", "INSERT INTO [GXA0047] ([ClinicaCodigo], [ExpedienteId], [ExpedienteLinea], [ExpedienteArchivo], [ExpedienteDescripcion], [ExpedienteFechaL], [ExpedienteHoraL], [UsuarioCodigoL]) VALUES (@AV2ClinicaCodigo, @AV3ExpedienteId, @AV4ExpedienteLinea, @AV5ExpedienteArchivo, @AV6ExpedienteDescripcion, @AV7ExpedienteFechaL, @AV8ExpedienteHoraL, @AV9UsuarioCodigoL)", GxErrorMask.GX_NOMASK,prmEXPEDIENTE3)
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
                ((String[]) buf[1])[0] = rslt.getString(2, 8) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
                ((String[]) buf[8])[0] = rslt.getBLOBFile(9, "JPG", "") ;
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                break;
       }
    }

 }

}
