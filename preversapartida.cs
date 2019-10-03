/*
               File: pReversaPartida
        Description: Reversa Partidas Contables Mayorizadas
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:57.82
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
   public class preversapartida : GXProcedure
   {
      public preversapartida( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public preversapartida( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref String aP1_TipoParCodigo ,
                           ref int aP2_MovMayorizadoId ,
                           ref String aP3_UsuarioCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.AV8MovMayorizadoId = aP2_MovMayorizadoId;
         this.AV9UsuarioCodigo = aP3_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_MovMayorizadoId=this.AV8MovMayorizadoId;
         aP3_UsuarioCodigo=this.AV9UsuarioCodigo;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref String aP1_TipoParCodigo ,
                                ref int aP2_MovMayorizadoId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.AV8MovMayorizadoId = aP2_MovMayorizadoId;
         this.AV9UsuarioCodigo = aP3_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_MovMayorizadoId=this.AV8MovMayorizadoId;
         aP3_UsuarioCodigo=this.AV9UsuarioCodigo;
         return AV9UsuarioCodigo ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_MovMayorizadoId ,
                                 ref String aP3_UsuarioCodigo )
      {
         preversapartida objpreversapartida;
         objpreversapartida = new preversapartida();
         objpreversapartida.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpreversapartida.A199TipoParCodigo = aP1_TipoParCodigo;
         objpreversapartida.AV8MovMayorizadoId = aP2_MovMayorizadoId;
         objpreversapartida.AV9UsuarioCodigo = aP3_UsuarioCodigo;
         objpreversapartida.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpreversapartida);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_MovMayorizadoId=this.AV8MovMayorizadoId;
         aP3_UsuarioCodigo=this.AV9UsuarioCodigo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((preversapartida)stateInfo).executePrivate();
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
         /* Using cursor P001A2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, AV8MovMayorizadoId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A217MovMayorizadoId = P001A2_A217MovMayorizadoId[0] ;
            A218MovMayorizadoLinea = P001A2_A218MovMayorizadoLinea[0] ;
            A219MovMayorizadoFecha = P001A2_A219MovMayorizadoFecha[0] ;
            A220MovMayorizadoHora = P001A2_A220MovMayorizadoHora[0] ;
            A221MovMayorizadoObs = P001A2_A221MovMayorizadoObs[0] ;
            A222MovMayorizadoReferencia = P001A2_A222MovMayorizadoReferencia[0] ;
            A223MovMayorizadoDebe = P001A2_A223MovMayorizadoDebe[0] ;
            A224MovMayorizadoHaber = P001A2_A224MovMayorizadoHaber[0] ;
            A193CtaContableCodigo = P001A2_A193CtaContableCodigo[0] ;
            /*
               INSERT RECORD ON TABLE MovimientoReversado

            */
            W193CtaContableCodigo = A193CtaContableCodigo ;
            W4UsuarioCodigo = A4UsuarioCodigo ;
            A290MovReversadoId = A217MovMayorizadoId ;
            A291MovReversadoLinea = A218MovMayorizadoLinea ;
            A292MovReversadoFecha = A219MovMayorizadoFecha ;
            A293MovReversadoHora = A220MovMayorizadoHora ;
            A294MovReversadoObs = A221MovMayorizadoObs ;
            A295MovReversadoReferencia = A222MovMayorizadoReferencia ;
            A296MovReversadoDebe = A223MovMayorizadoDebe ;
            A297MovReversadoHaber = A224MovMayorizadoHaber ;
            A4UsuarioCodigo = AV9UsuarioCodigo ;
            A298MovReversadoFechaR = Gx_date ;
            A299MovReversadoHoraR = Gx_time ;
            /* Using cursor P001A3 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A290MovReversadoId, A291MovReversadoLinea, A292MovReversadoFecha, A293MovReversadoHora, A294MovReversadoObs, A295MovReversadoReferencia, A193CtaContableCodigo, A296MovReversadoDebe, A297MovReversadoHaber, A4UsuarioCodigo, A298MovReversadoFechaR, A299MovReversadoHoraR});
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
            A193CtaContableCodigo = W193CtaContableCodigo ;
            A4UsuarioCodigo = W4UsuarioCodigo ;
            /* End Insert */
            /* Using cursor P001A4 */
            pr_default.execute(2, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea});
            pr_default.close(2);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         /* Optimized UPDATE. */
         /* Using cursor P001A5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, AV8MovMayorizadoId});
         pr_default.close(3);
         /* End optimized UPDATE. */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pReversaPartida");
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
         P001A2_A41ClinicaCodigo = new String[] {""} ;
         P001A2_A199TipoParCodigo = new String[] {""} ;
         P001A2_A217MovMayorizadoId = new int[1] ;
         P001A2_A218MovMayorizadoLinea = new short[1] ;
         P001A2_A219MovMayorizadoFecha = new DateTime[] {DateTime.MinValue} ;
         P001A2_A220MovMayorizadoHora = new String[] {""} ;
         P001A2_A221MovMayorizadoObs = new String[] {""} ;
         P001A2_A222MovMayorizadoReferencia = new String[] {""} ;
         P001A2_A223MovMayorizadoDebe = new decimal[1] ;
         P001A2_A224MovMayorizadoHaber = new decimal[1] ;
         P001A2_A193CtaContableCodigo = new String[] {""} ;
         A219MovMayorizadoFecha = DateTime.MinValue ;
         A220MovMayorizadoHora = "" ;
         A221MovMayorizadoObs = "" ;
         A222MovMayorizadoReferencia = "" ;
         A193CtaContableCodigo = "" ;
         W193CtaContableCodigo = "" ;
         W4UsuarioCodigo = "" ;
         A4UsuarioCodigo = "" ;
         A292MovReversadoFecha = DateTime.MinValue ;
         A293MovReversadoHora = "" ;
         A294MovReversadoObs = "" ;
         A295MovReversadoReferencia = "" ;
         A298MovReversadoFechaR = DateTime.MinValue ;
         Gx_date = DateTime.MinValue ;
         A299MovReversadoHoraR = "" ;
         Gx_time = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.preversapartida__default(),
            new Object[][] {
                new Object[] {
               P001A2_A41ClinicaCodigo, P001A2_A199TipoParCodigo, P001A2_A217MovMayorizadoId, P001A2_A218MovMayorizadoLinea, P001A2_A219MovMayorizadoFecha, P001A2_A220MovMayorizadoHora, P001A2_A221MovMayorizadoObs, P001A2_A222MovMayorizadoReferencia, P001A2_A223MovMayorizadoDebe, P001A2_A224MovMayorizadoHaber,
               P001A2_A193CtaContableCodigo
               }
               , new Object[] {
               }
               , new Object[] {
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

      private short A218MovMayorizadoLinea ;
      private short A291MovReversadoLinea ;
      private int AV8MovMayorizadoId ;
      private int A217MovMayorizadoId ;
      private int GX_INS70 ;
      private int A290MovReversadoId ;
      private decimal A223MovMayorizadoDebe ;
      private decimal A224MovMayorizadoHaber ;
      private decimal A296MovReversadoDebe ;
      private decimal A297MovReversadoHaber ;
      private String scmdbuf ;
      private String A220MovMayorizadoHora ;
      private String A293MovReversadoHora ;
      private String A299MovReversadoHoraR ;
      private String Gx_time ;
      private String Gx_emsg ;
      private DateTime A219MovMayorizadoFecha ;
      private DateTime A292MovReversadoFecha ;
      private DateTime A298MovReversadoFechaR ;
      private DateTime Gx_date ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String AV9UsuarioCodigo ;
      private String A221MovMayorizadoObs ;
      private String A222MovMayorizadoReferencia ;
      private String A193CtaContableCodigo ;
      private String W193CtaContableCodigo ;
      private String W4UsuarioCodigo ;
      private String A4UsuarioCodigo ;
      private String A294MovReversadoObs ;
      private String A295MovReversadoReferencia ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoParCodigo ;
      private int aP2_MovMayorizadoId ;
      private String aP3_UsuarioCodigo ;
      private IDataStoreProvider pr_default ;
      private String[] P001A2_A41ClinicaCodigo ;
      private String[] P001A2_A199TipoParCodigo ;
      private int[] P001A2_A217MovMayorizadoId ;
      private short[] P001A2_A218MovMayorizadoLinea ;
      private DateTime[] P001A2_A219MovMayorizadoFecha ;
      private String[] P001A2_A220MovMayorizadoHora ;
      private String[] P001A2_A221MovMayorizadoObs ;
      private String[] P001A2_A222MovMayorizadoReferencia ;
      private decimal[] P001A2_A223MovMayorizadoDebe ;
      private decimal[] P001A2_A224MovMayorizadoHaber ;
      private String[] P001A2_A193CtaContableCodigo ;
   }

   public class preversapartida__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new UpdateCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001A2 ;
          prmP001A2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8MovMayorizadoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP001A3 ;
          prmP001A3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovReversadoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovReversadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovReversadoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@MovReversadoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovReversadoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovReversadoHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovReversadoFechaR",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovReversadoHoraR",SqlDbType.Char,8,0}
          } ;
          Object[] prmP001A4 ;
          prmP001A4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmP001A5 ;
          prmP001A5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8MovMayorizadoId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001A2", "SELECT [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea], [MovMayorizadoFecha], [MovMayorizadoHora], [MovMayorizadoObs], [MovMayorizadoReferencia], [MovMayorizadoDebe], [MovMayorizadoHaber], [CtaContableCodigo] FROM [MovimientoMayorizado] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [MovMayorizadoId] = @AV8MovMayorizadoId ORDER BY [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001A2,1,0,true,false )
             ,new CursorDef("P001A3", "INSERT INTO [MovimientoReversado] ([ClinicaCodigo], [TipoParCodigo], [MovReversadoId], [MovReversadoLinea], [MovReversadoFecha], [MovReversadoHora], [MovReversadoObs], [MovReversadoReferencia], [CtaContableCodigo], [MovReversadoDebe], [MovReversadoHaber], [UsuarioCodigo], [MovReversadoFechaR], [MovReversadoHoraR]) VALUES (@ClinicaCodigo, @TipoParCodigo, @MovReversadoId, @MovReversadoLinea, @MovReversadoFecha, @MovReversadoHora, @MovReversadoObs, @MovReversadoReferencia, @CtaContableCodigo, @MovReversadoDebe, @MovReversadoHaber, @UsuarioCodigo, @MovReversadoFechaR, @MovReversadoHoraR)", GxErrorMask.GX_NOMASK,prmP001A3)
             ,new CursorDef("P001A4", "DELETE FROM [MovimientoMayorizado]  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [MovMayorizadoId] = @MovMayorizadoId AND [MovMayorizadoLinea] = @MovMayorizadoLinea", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001A4)
             ,new CursorDef("P001A5", "UPDATE [PartidaEnc] SET [PartidaEstado]=2  WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [PartidaId] = @AV8MovMayorizadoId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP001A5)
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 8) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((decimal[]) buf[8])[0] = rslt.getDecimal(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
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
                stmt.SetParameter(13, (DateTime)parms[12]);
                stmt.SetParameter(14, (String)parms[13]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
       }
    }

 }

}
