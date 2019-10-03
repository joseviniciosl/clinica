/*
               File: pRegistraExpedienteDet
        Description: Registra Detalle del Expediente Médico Físico
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:39.7
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
   public class pregistraexpedientedet : GXProcedure
   {
      public pregistraexpedientedet( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistraexpedientedet( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_ExpedienteId ,
                           ref String aP2_ExpedienteArchivo ,
                           ref String aP3_ExpedienteDescripcion ,
                           ref String aP4_UsuarioCodigoL )
      {
         this.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV9ExpedienteId = aP1_ExpedienteId;
         this.AV11ExpedienteArchivo = aP2_ExpedienteArchivo;
         this.AV12ExpedienteDescripcion = aP3_ExpedienteDescripcion;
         this.AV13UsuarioCodigoL = aP4_UsuarioCodigoL;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_ExpedienteId=this.AV9ExpedienteId;
         aP2_ExpedienteArchivo=this.AV11ExpedienteArchivo;
         aP3_ExpedienteDescripcion=this.AV12ExpedienteDescripcion;
         aP4_UsuarioCodigoL=this.AV13UsuarioCodigoL;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref int aP1_ExpedienteId ,
                                ref String aP2_ExpedienteArchivo ,
                                ref String aP3_ExpedienteDescripcion )
      {
         this.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV9ExpedienteId = aP1_ExpedienteId;
         this.AV11ExpedienteArchivo = aP2_ExpedienteArchivo;
         this.AV12ExpedienteDescripcion = aP3_ExpedienteDescripcion;
         this.AV13UsuarioCodigoL = aP4_UsuarioCodigoL;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_ExpedienteId=this.AV9ExpedienteId;
         aP2_ExpedienteArchivo=this.AV11ExpedienteArchivo;
         aP3_ExpedienteDescripcion=this.AV12ExpedienteDescripcion;
         aP4_UsuarioCodigoL=this.AV13UsuarioCodigoL;
         return AV13UsuarioCodigoL ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_ExpedienteId ,
                                 ref String aP2_ExpedienteArchivo ,
                                 ref String aP3_ExpedienteDescripcion ,
                                 ref String aP4_UsuarioCodigoL )
      {
         pregistraexpedientedet objpregistraexpedientedet;
         objpregistraexpedientedet = new pregistraexpedientedet();
         objpregistraexpedientedet.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistraexpedientedet.AV9ExpedienteId = aP1_ExpedienteId;
         objpregistraexpedientedet.AV11ExpedienteArchivo = aP2_ExpedienteArchivo;
         objpregistraexpedientedet.AV12ExpedienteDescripcion = aP3_ExpedienteDescripcion;
         objpregistraexpedientedet.AV13UsuarioCodigoL = aP4_UsuarioCodigoL;
         objpregistraexpedientedet.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistraexpedientedet);
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_ExpedienteId=this.AV9ExpedienteId;
         aP2_ExpedienteArchivo=this.AV11ExpedienteArchivo;
         aP3_ExpedienteDescripcion=this.AV12ExpedienteDescripcion;
         aP4_UsuarioCodigoL=this.AV13UsuarioCodigoL;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistraexpedientedet)stateInfo).executePrivate();
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
         AV16GXLvl2 = 0 ;
         /* Using cursor P000D2 */
         pr_default.execute(0, new Object[] {AV8ClinicaCodigo, AV9ExpedienteId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A167ExpedienteId = P000D2_A167ExpedienteId[0] ;
            A41ClinicaCodigo = P000D2_A41ClinicaCodigo[0] ;
            A170ExpedienteLinea = P000D2_A170ExpedienteLinea[0] ;
            AV16GXLvl2 = 1 ;
            AV10ExpedienteLinea = A170ExpedienteLinea ;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV16GXLvl2 == 0 )
         {
            AV10ExpedienteLinea = 0 ;
         }
         AV10ExpedienteLinea = (short)(AV10ExpedienteLinea+1) ;
         /*
            INSERT RECORD ON TABLE ExpedienteDet

         */
         A41ClinicaCodigo = AV8ClinicaCodigo ;
         A167ExpedienteId = AV9ExpedienteId ;
         A170ExpedienteLinea = AV10ExpedienteLinea ;
         A171ExpedienteArchivo = AV11ExpedienteArchivo ;
         A172ExpedienteDescripcion = AV12ExpedienteDescripcion ;
         A173ExpedienteFechaL = Gx_date ;
         A174ExpedienteHoraL = Gx_time ;
         A175UsuarioCodigoL = AV13UsuarioCodigoL ;
         /* Using cursor P000D3 */
         pr_default.execute(1, new Object[] {A41ClinicaCodigo, A167ExpedienteId, A170ExpedienteLinea, A171ExpedienteArchivo, A172ExpedienteDescripcion, A173ExpedienteFechaL, A174ExpedienteHoraL, A175UsuarioCodigoL});
         pr_default.close(1);
         if ( (pr_default.getStatus(1) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
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
         context.CommitDataStores("pRegistraExpedienteDet");
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
         P000D2_A167ExpedienteId = new int[1] ;
         P000D2_A41ClinicaCodigo = new String[] {""} ;
         P000D2_A170ExpedienteLinea = new short[1] ;
         A41ClinicaCodigo = "" ;
         A171ExpedienteArchivo = "" ;
         A172ExpedienteDescripcion = "" ;
         A173ExpedienteFechaL = DateTime.MinValue ;
         Gx_date = DateTime.MinValue ;
         A174ExpedienteHoraL = "" ;
         Gx_time = "" ;
         A175UsuarioCodigoL = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistraexpedientedet__default(),
            new Object[][] {
                new Object[] {
               P000D2_A167ExpedienteId, P000D2_A41ClinicaCodigo, P000D2_A170ExpedienteLinea
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

      private short AV16GXLvl2 ;
      private short A170ExpedienteLinea ;
      private short AV10ExpedienteLinea ;
      private int AV9ExpedienteId ;
      private int A167ExpedienteId ;
      private int GX_INS47 ;
      private String scmdbuf ;
      private String A174ExpedienteHoraL ;
      private String Gx_time ;
      private String Gx_emsg ;
      private DateTime A173ExpedienteFechaL ;
      private DateTime Gx_date ;
      private String AV8ClinicaCodigo ;
      private String AV12ExpedienteDescripcion ;
      private String AV13UsuarioCodigoL ;
      private String A41ClinicaCodigo ;
      private String A172ExpedienteDescripcion ;
      private String A175UsuarioCodigoL ;
      private String AV11ExpedienteArchivo ;
      private String A171ExpedienteArchivo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ExpedienteId ;
      private String aP2_ExpedienteArchivo ;
      private String aP3_ExpedienteDescripcion ;
      private String aP4_UsuarioCodigoL ;
      private IDataStoreProvider pr_default ;
      private int[] P000D2_A167ExpedienteId ;
      private String[] P000D2_A41ClinicaCodigo ;
      private short[] P000D2_A170ExpedienteLinea ;
   }

   public class pregistraexpedientedet__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000D2 ;
          prmP000D2 = new Object[] {
          new Object[] {"@AV8ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV9ExpedienteId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000D3 ;
          prmP000D3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@ExpedienteLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ExpedienteArchivo",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ExpedienteDescripcion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@ExpedienteFechaL",SqlDbType.DateTime,8,0} ,
          new Object[] {"@ExpedienteHoraL",SqlDbType.Char,8,0} ,
          new Object[] {"@UsuarioCodigoL",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000D2", "SELECT TOP 1 [ExpedienteId], [ClinicaCodigo], [ExpedienteLinea] FROM [ExpedienteDet] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV8ClinicaCodigo) AND ([ExpedienteId] = @AV9ExpedienteId) ORDER BY [ExpedienteLinea] DESC ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000D2,1,0,false,true )
             ,new CursorDef("P000D3", "INSERT INTO [ExpedienteDet] ([ClinicaCodigo], [ExpedienteId], [ExpedienteLinea], [ExpedienteArchivo], [ExpedienteDescripcion], [ExpedienteFechaL], [ExpedienteHoraL], [UsuarioCodigoL]) VALUES (@ClinicaCodigo, @ExpedienteId, @ExpedienteLinea, @ExpedienteArchivo, @ExpedienteDescripcion, @ExpedienteFechaL, @ExpedienteHoraL, @UsuarioCodigoL)", GxErrorMask.GX_NOMASK,prmP000D3)
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
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
