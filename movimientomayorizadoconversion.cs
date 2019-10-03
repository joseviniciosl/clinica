/*
               File: MovimientoMayorizadoConversion
        Description: Conversion for table MovimientoMayorizado
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:25.53
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
   public class movimientomayorizadoconversion : GXProcedure
   {
      public movimientomayorizadoconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public movimientomayorizadoconversion( IGxContext context )
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
         movimientomayorizadoconversion objmovimientomayorizadoconversion;
         objmovimientomayorizadoconversion = new movimientomayorizadoconversion();
         objmovimientomayorizadoconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objmovimientomayorizadoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((movimientomayorizadoconversion)stateInfo).executePrivate();
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
         /* Using cursor MOVIMIENTO2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A4UsuarioCodigo = MOVIMIENTO2_A4UsuarioCodigo[0] ;
            A224MovMayorizadoHaber = MOVIMIENTO2_A224MovMayorizadoHaber[0] ;
            A223MovMayorizadoDebe = MOVIMIENTO2_A223MovMayorizadoDebe[0] ;
            A193CtaContableCodigo = MOVIMIENTO2_A193CtaContableCodigo[0] ;
            A222MovMayorizadoReferencia = MOVIMIENTO2_A222MovMayorizadoReferencia[0] ;
            A221MovMayorizadoObs = MOVIMIENTO2_A221MovMayorizadoObs[0] ;
            A220MovMayorizadoHora = MOVIMIENTO2_A220MovMayorizadoHora[0] ;
            A219MovMayorizadoFecha = MOVIMIENTO2_A219MovMayorizadoFecha[0] ;
            A218MovMayorizadoLinea = MOVIMIENTO2_A218MovMayorizadoLinea[0] ;
            A217MovMayorizadoId = MOVIMIENTO2_A217MovMayorizadoId[0] ;
            A199TipoParCodigo = MOVIMIENTO2_A199TipoParCodigo[0] ;
            A41ClinicaCodigo = MOVIMIENTO2_A41ClinicaCodigo[0] ;
            A40000GXC1 = MOVIMIENTO2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0055

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoParCodigo = A199TipoParCodigo ;
            AV4MovMayorizadoId = A217MovMayorizadoId ;
            AV5MovMayorizadoLinea = A218MovMayorizadoLinea ;
            AV6MovMayorizadoFecha = A219MovMayorizadoFecha ;
            AV7MovMayorizadoHora = A220MovMayorizadoHora ;
            AV8MovMayorizadoObs = A221MovMayorizadoObs ;
            AV9MovMayorizadoReferencia = A222MovMayorizadoReferencia ;
            AV10CtaContableCodigo = A193CtaContableCodigo ;
            AV11MovMayorizadoDebe = A223MovMayorizadoDebe ;
            AV12MovMayorizadoHaber = A224MovMayorizadoHaber ;
            AV13UsuarioCodigo = A4UsuarioCodigo ;
            /* Using cursor MOVIMIENTO3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoParCodigo, AV4MovMayorizadoId, AV5MovMayorizadoLinea, AV6MovMayorizadoFecha, AV7MovMayorizadoHora, AV8MovMayorizadoObs, AV9MovMayorizadoReferencia, AV10CtaContableCodigo, AV11MovMayorizadoDebe, AV12MovMayorizadoHaber, AV13UsuarioCodigo});
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
         MOVIMIENTO2_A4UsuarioCodigo = new String[] {""} ;
         MOVIMIENTO2_A224MovMayorizadoHaber = new decimal[1] ;
         MOVIMIENTO2_A223MovMayorizadoDebe = new decimal[1] ;
         MOVIMIENTO2_A193CtaContableCodigo = new String[] {""} ;
         MOVIMIENTO2_A222MovMayorizadoReferencia = new String[] {""} ;
         MOVIMIENTO2_A221MovMayorizadoObs = new String[] {""} ;
         MOVIMIENTO2_A220MovMayorizadoHora = new String[] {""} ;
         MOVIMIENTO2_A219MovMayorizadoFecha = new DateTime[] {DateTime.MinValue} ;
         MOVIMIENTO2_A218MovMayorizadoLinea = new short[1] ;
         MOVIMIENTO2_A217MovMayorizadoId = new int[1] ;
         MOVIMIENTO2_A199TipoParCodigo = new String[] {""} ;
         MOVIMIENTO2_A41ClinicaCodigo = new String[] {""} ;
         MOVIMIENTO2_A40000GXC1 = new int[1] ;
         A4UsuarioCodigo = "" ;
         A193CtaContableCodigo = "" ;
         A222MovMayorizadoReferencia = "" ;
         A221MovMayorizadoObs = "" ;
         A220MovMayorizadoHora = "" ;
         A219MovMayorizadoFecha = DateTime.MinValue ;
         A199TipoParCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoParCodigo = "" ;
         AV6MovMayorizadoFecha = DateTime.MinValue ;
         AV7MovMayorizadoHora = "" ;
         AV8MovMayorizadoObs = "" ;
         AV9MovMayorizadoReferencia = "" ;
         AV10CtaContableCodigo = "" ;
         AV13UsuarioCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.movimientomayorizadoconversion__default(),
            new Object[][] {
                new Object[] {
               MOVIMIENTO2_A4UsuarioCodigo, MOVIMIENTO2_A224MovMayorizadoHaber, MOVIMIENTO2_A223MovMayorizadoDebe, MOVIMIENTO2_A193CtaContableCodigo, MOVIMIENTO2_A222MovMayorizadoReferencia, MOVIMIENTO2_A221MovMayorizadoObs, MOVIMIENTO2_A220MovMayorizadoHora, MOVIMIENTO2_A219MovMayorizadoFecha, MOVIMIENTO2_A218MovMayorizadoLinea, MOVIMIENTO2_A217MovMayorizadoId,
               MOVIMIENTO2_A199TipoParCodigo, MOVIMIENTO2_A41ClinicaCodigo, MOVIMIENTO2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A218MovMayorizadoLinea ;
      private short AV5MovMayorizadoLinea ;
      private int A217MovMayorizadoId ;
      private int A40000GXC1 ;
      private int GIGXA0055 ;
      private int AV2ClinicaCodigo ;
      private int AV4MovMayorizadoId ;
      private decimal A224MovMayorizadoHaber ;
      private decimal A223MovMayorizadoDebe ;
      private decimal AV11MovMayorizadoDebe ;
      private decimal AV12MovMayorizadoHaber ;
      private String scmdbuf ;
      private String A220MovMayorizadoHora ;
      private String AV7MovMayorizadoHora ;
      private String Gx_emsg ;
      private DateTime A219MovMayorizadoFecha ;
      private DateTime AV6MovMayorizadoFecha ;
      private String A4UsuarioCodigo ;
      private String A193CtaContableCodigo ;
      private String A222MovMayorizadoReferencia ;
      private String A221MovMayorizadoObs ;
      private String A199TipoParCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoParCodigo ;
      private String AV8MovMayorizadoObs ;
      private String AV9MovMayorizadoReferencia ;
      private String AV10CtaContableCodigo ;
      private String AV13UsuarioCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] MOVIMIENTO2_A4UsuarioCodigo ;
      private decimal[] MOVIMIENTO2_A224MovMayorizadoHaber ;
      private decimal[] MOVIMIENTO2_A223MovMayorizadoDebe ;
      private String[] MOVIMIENTO2_A193CtaContableCodigo ;
      private String[] MOVIMIENTO2_A222MovMayorizadoReferencia ;
      private String[] MOVIMIENTO2_A221MovMayorizadoObs ;
      private String[] MOVIMIENTO2_A220MovMayorizadoHora ;
      private DateTime[] MOVIMIENTO2_A219MovMayorizadoFecha ;
      private short[] MOVIMIENTO2_A218MovMayorizadoLinea ;
      private int[] MOVIMIENTO2_A217MovMayorizadoId ;
      private String[] MOVIMIENTO2_A199TipoParCodigo ;
      private String[] MOVIMIENTO2_A41ClinicaCodigo ;
      private int[] MOVIMIENTO2_A40000GXC1 ;
   }

   public class movimientomayorizadoconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmMOVIMIENTO2 ;
          prmMOVIMIENTO2 = new Object[] {
          } ;
          Object[] prmMOVIMIENTO3 ;
          prmMOVIMIENTO3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV5MovMayorizadoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6MovMayorizadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV7MovMayorizadoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV8MovMayorizadoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV9MovMayorizadoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV10CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11MovMayorizadoDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV12MovMayorizadoHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV13UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("MOVIMIENTO2", "SELECT [UsuarioCodigo], [MovMayorizadoHaber], [MovMayorizadoDebe], [CtaContableCodigo], [MovMayorizadoReferencia], [MovMayorizadoObs], [MovMayorizadoHora], [MovMayorizadoFecha], [MovMayorizadoLinea], [MovMayorizadoId], [TipoParCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [MovimientoMayorizado] ORDER BY [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmMOVIMIENTO2,100,0,true,false )
             ,new CursorDef("MOVIMIENTO3", "INSERT INTO [GXA0055] ([ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea], [MovMayorizadoFecha], [MovMayorizadoHora], [MovMayorizadoObs], [MovMayorizadoReferencia], [CtaContableCodigo], [MovMayorizadoDebe], [MovMayorizadoHaber], [UsuarioCodigo]) VALUES (@AV2ClinicaCodigo, @AV3TipoParCodigo, @AV4MovMayorizadoId, @AV5MovMayorizadoLinea, @AV6MovMayorizadoFecha, @AV7MovMayorizadoHora, @AV8MovMayorizadoObs, @AV9MovMayorizadoReferencia, @AV10CtaContableCodigo, @AV11MovMayorizadoDebe, @AV12MovMayorizadoHaber, @AV13UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmMOVIMIENTO3)
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 8) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((int[]) buf[9])[0] = rslt.getInt(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(12) ;
                ((int[]) buf[12])[0] = rslt.getInt(13) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (decimal)parms[9]);
                stmt.SetParameter(11, (decimal)parms[10]);
                stmt.SetParameter(12, (String)parms[11]);
                break;
       }
    }

 }

}
