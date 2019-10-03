/*
               File: pMayorizaPartida
        Description: Mayoriza Partida Contable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:56.52
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
   public class pmayorizapartida : GXProcedure
   {
      public pmayorizapartida( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pmayorizapartida( IGxContext context )
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
                           ref int aP2_PartidaId ,
                           ref short aP3_PartidaEstado ,
                           ref short aP4_PartidaMayorizada ,
                           ref String aP5_UsuarioCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.AV8PartidaId = aP2_PartidaId;
         this.AV10PartidaEstado = aP3_PartidaEstado;
         this.AV11PartidaMayorizada = aP4_PartidaMayorizada;
         this.AV9UsuarioCodigo = aP5_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.AV8PartidaId;
         aP3_PartidaEstado=this.AV10PartidaEstado;
         aP4_PartidaMayorizada=this.AV11PartidaMayorizada;
         aP5_UsuarioCodigo=this.AV9UsuarioCodigo;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref String aP1_TipoParCodigo ,
                                ref int aP2_PartidaId ,
                                ref short aP3_PartidaEstado ,
                                ref short aP4_PartidaMayorizada )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.AV8PartidaId = aP2_PartidaId;
         this.AV10PartidaEstado = aP3_PartidaEstado;
         this.AV11PartidaMayorizada = aP4_PartidaMayorizada;
         this.AV9UsuarioCodigo = aP5_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.AV8PartidaId;
         aP3_PartidaEstado=this.AV10PartidaEstado;
         aP4_PartidaMayorizada=this.AV11PartidaMayorizada;
         aP5_UsuarioCodigo=this.AV9UsuarioCodigo;
         return AV9UsuarioCodigo ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_PartidaId ,
                                 ref short aP3_PartidaEstado ,
                                 ref short aP4_PartidaMayorizada ,
                                 ref String aP5_UsuarioCodigo )
      {
         pmayorizapartida objpmayorizapartida;
         objpmayorizapartida = new pmayorizapartida();
         objpmayorizapartida.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpmayorizapartida.A199TipoParCodigo = aP1_TipoParCodigo;
         objpmayorizapartida.AV8PartidaId = aP2_PartidaId;
         objpmayorizapartida.AV10PartidaEstado = aP3_PartidaEstado;
         objpmayorizapartida.AV11PartidaMayorizada = aP4_PartidaMayorizada;
         objpmayorizapartida.AV9UsuarioCodigo = aP5_UsuarioCodigo;
         objpmayorizapartida.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpmayorizapartida);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.AV8PartidaId;
         aP3_PartidaEstado=this.AV10PartidaEstado;
         aP4_PartidaMayorizada=this.AV11PartidaMayorizada;
         aP5_UsuarioCodigo=this.AV9UsuarioCodigo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pmayorizapartida)stateInfo).executePrivate();
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
         /* Using cursor P00172 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, AV8PartidaId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A207PartidaId = P00172_A207PartidaId[0] ;
            A289PartidaEstado = P00172_A289PartidaEstado[0] ;
            A211PartidaMayorizada = P00172_A211PartidaMayorizada[0] ;
            /* Using cursor P00173 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A214PartidaLinea = P00173_A214PartidaLinea[0] ;
               A208PartidaFecha = P00173_A208PartidaFecha[0] ;
               A209PartidaHora = P00173_A209PartidaHora[0] ;
               A210PartidaObs = P00173_A210PartidaObs[0] ;
               A212PartidaReferencia = P00173_A212PartidaReferencia[0] ;
               A215PartidaDebe = P00173_A215PartidaDebe[0] ;
               A216PartidaHaber = P00173_A216PartidaHaber[0] ;
               A193CtaContableCodigo = P00173_A193CtaContableCodigo[0] ;
               A208PartidaFecha = P00173_A208PartidaFecha[0] ;
               A209PartidaHora = P00173_A209PartidaHora[0] ;
               A210PartidaObs = P00173_A210PartidaObs[0] ;
               A212PartidaReferencia = P00173_A212PartidaReferencia[0] ;
               /*
                  INSERT RECORD ON TABLE MovimientoMayorizado

               */
               W193CtaContableCodigo = A193CtaContableCodigo ;
               W4UsuarioCodigo = A4UsuarioCodigo ;
               A217MovMayorizadoId = A207PartidaId ;
               A218MovMayorizadoLinea = A214PartidaLinea ;
               A219MovMayorizadoFecha = A208PartidaFecha ;
               A220MovMayorizadoHora = A209PartidaHora ;
               A221MovMayorizadoObs = A210PartidaObs ;
               A222MovMayorizadoReferencia = A212PartidaReferencia ;
               A223MovMayorizadoDebe = A215PartidaDebe ;
               A224MovMayorizadoHaber = A216PartidaHaber ;
               A4UsuarioCodigo = AV9UsuarioCodigo ;
               /* Using cursor P00174 */
               pr_default.execute(2, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A217MovMayorizadoId, A218MovMayorizadoLinea, A219MovMayorizadoFecha, A220MovMayorizadoHora, A221MovMayorizadoObs, A222MovMayorizadoReferencia, A193CtaContableCodigo, A223MovMayorizadoDebe, A224MovMayorizadoHaber, A4UsuarioCodigo});
               pr_default.close(2);
               if ( (pr_default.getStatus(2) == 1) )
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
               pr_default.readNext(1);
            }
            pr_default.close(1);
            A289PartidaEstado = AV10PartidaEstado ;
            A211PartidaMayorizada = AV11PartidaMayorizada ;
            /* Using cursor P00175 */
            pr_default.execute(3, new Object[] {A289PartidaEstado, A211PartidaMayorizada, A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
            pr_default.close(3);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pMayorizaPartida");
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
         P00172_A41ClinicaCodigo = new String[] {""} ;
         P00172_A199TipoParCodigo = new String[] {""} ;
         P00172_A207PartidaId = new int[1] ;
         P00172_A289PartidaEstado = new short[1] ;
         P00172_A211PartidaMayorizada = new short[1] ;
         P00173_A41ClinicaCodigo = new String[] {""} ;
         P00173_A199TipoParCodigo = new String[] {""} ;
         P00173_A207PartidaId = new int[1] ;
         P00173_A214PartidaLinea = new short[1] ;
         P00173_A208PartidaFecha = new DateTime[] {DateTime.MinValue} ;
         P00173_A209PartidaHora = new String[] {""} ;
         P00173_A210PartidaObs = new String[] {""} ;
         P00173_A212PartidaReferencia = new String[] {""} ;
         P00173_A215PartidaDebe = new decimal[1] ;
         P00173_A216PartidaHaber = new decimal[1] ;
         P00173_A193CtaContableCodigo = new String[] {""} ;
         A208PartidaFecha = DateTime.MinValue ;
         A209PartidaHora = "" ;
         A210PartidaObs = "" ;
         A212PartidaReferencia = "" ;
         A193CtaContableCodigo = "" ;
         W193CtaContableCodigo = "" ;
         W4UsuarioCodigo = "" ;
         A4UsuarioCodigo = "" ;
         A219MovMayorizadoFecha = DateTime.MinValue ;
         A220MovMayorizadoHora = "" ;
         A221MovMayorizadoObs = "" ;
         A222MovMayorizadoReferencia = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pmayorizapartida__default(),
            new Object[][] {
                new Object[] {
               P00172_A41ClinicaCodigo, P00172_A199TipoParCodigo, P00172_A207PartidaId, P00172_A289PartidaEstado, P00172_A211PartidaMayorizada
               }
               , new Object[] {
               P00173_A41ClinicaCodigo, P00173_A199TipoParCodigo, P00173_A207PartidaId, P00173_A214PartidaLinea, P00173_A208PartidaFecha, P00173_A209PartidaHora, P00173_A210PartidaObs, P00173_A212PartidaReferencia, P00173_A215PartidaDebe, P00173_A216PartidaHaber,
               P00173_A193CtaContableCodigo
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV10PartidaEstado ;
      private short AV11PartidaMayorizada ;
      private short A289PartidaEstado ;
      private short A211PartidaMayorizada ;
      private short A214PartidaLinea ;
      private short A218MovMayorizadoLinea ;
      private int AV8PartidaId ;
      private int A207PartidaId ;
      private int GX_INS55 ;
      private int A217MovMayorizadoId ;
      private decimal A215PartidaDebe ;
      private decimal A216PartidaHaber ;
      private decimal A223MovMayorizadoDebe ;
      private decimal A224MovMayorizadoHaber ;
      private String scmdbuf ;
      private String A209PartidaHora ;
      private String A220MovMayorizadoHora ;
      private String Gx_emsg ;
      private DateTime A208PartidaFecha ;
      private DateTime A219MovMayorizadoFecha ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String AV9UsuarioCodigo ;
      private String A210PartidaObs ;
      private String A212PartidaReferencia ;
      private String A193CtaContableCodigo ;
      private String W193CtaContableCodigo ;
      private String W4UsuarioCodigo ;
      private String A4UsuarioCodigo ;
      private String A221MovMayorizadoObs ;
      private String A222MovMayorizadoReferencia ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoParCodigo ;
      private int aP2_PartidaId ;
      private short aP3_PartidaEstado ;
      private short aP4_PartidaMayorizada ;
      private String aP5_UsuarioCodigo ;
      private IDataStoreProvider pr_default ;
      private String[] P00172_A41ClinicaCodigo ;
      private String[] P00172_A199TipoParCodigo ;
      private int[] P00172_A207PartidaId ;
      private short[] P00172_A289PartidaEstado ;
      private short[] P00172_A211PartidaMayorizada ;
      private String[] P00173_A41ClinicaCodigo ;
      private String[] P00173_A199TipoParCodigo ;
      private int[] P00173_A207PartidaId ;
      private short[] P00173_A214PartidaLinea ;
      private DateTime[] P00173_A208PartidaFecha ;
      private String[] P00173_A209PartidaHora ;
      private String[] P00173_A210PartidaObs ;
      private String[] P00173_A212PartidaReferencia ;
      private decimal[] P00173_A215PartidaDebe ;
      private decimal[] P00173_A216PartidaHaber ;
      private String[] P00173_A193CtaContableCodigo ;
   }

   public class pmayorizapartida__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new UpdateCursor(def[3])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00172 ;
          prmP00172 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP00173 ;
          prmP00173 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP00174 ;
          prmP00174 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@MovMayorizadoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@MovMayorizadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@MovMayorizadoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@MovMayorizadoObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@MovMayorizadoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@CtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@MovMayorizadoDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@MovMayorizadoHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP00175 ;
          prmP00175 = new Object[] {
          new Object[] {"@PartidaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@PartidaMayorizada",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00172", "SELECT [ClinicaCodigo], [TipoParCodigo], [PartidaId], [PartidaEstado], [PartidaMayorizada] FROM [PartidaEnc] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [TipoParCodigo] = @TipoParCodigo and [PartidaId] = @AV8PartidaId ORDER BY [ClinicaCodigo], [TipoParCodigo], [PartidaId] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00172,1,0,true,true )
             ,new CursorDef("P00173", "SELECT T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId], T1.[PartidaLinea], T2.[PartidaFecha], T2.[PartidaHora], T2.[PartidaObs], T2.[PartidaReferencia], T1.[PartidaDebe], T1.[PartidaHaber], T1.[CtaContableCodigo] FROM ([PartidaDet] T1 WITH (NOLOCK) INNER JOIN [PartidaEnc] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[TipoParCodigo] = T1.[TipoParCodigo] AND T2.[PartidaId] = T1.[PartidaId]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[TipoParCodigo] = @TipoParCodigo and T1.[PartidaId] = @PartidaId ORDER BY T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00173,100,0,true,false )
             ,new CursorDef("P00174", "INSERT INTO [MovimientoMayorizado] ([ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea], [MovMayorizadoFecha], [MovMayorizadoHora], [MovMayorizadoObs], [MovMayorizadoReferencia], [CtaContableCodigo], [MovMayorizadoDebe], [MovMayorizadoHaber], [UsuarioCodigo]) VALUES (@ClinicaCodigo, @TipoParCodigo, @MovMayorizadoId, @MovMayorizadoLinea, @MovMayorizadoFecha, @MovMayorizadoHora, @MovMayorizadoObs, @MovMayorizadoReferencia, @CtaContableCodigo, @MovMayorizadoDebe, @MovMayorizadoHaber, @UsuarioCodigo)", GxErrorMask.GX_NOMASK,prmP00174)
             ,new CursorDef("P00175", "UPDATE [PartidaEnc] SET [PartidaEstado]=@PartidaEstado, [PartidaMayorizada]=@PartidaMayorizada  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [TipoParCodigo] = @TipoParCodigo AND [PartidaId] = @PartidaId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP00175)
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
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 1 :
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
                break;
             case 2 :
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
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                break;
       }
    }

 }

}
