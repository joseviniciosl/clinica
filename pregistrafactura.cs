/*
               File: pRegistraFactura
        Description: Registra Factura de Paciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:44.33
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
   public class pregistrafactura : GXProcedure
   {
      public pregistrafactura( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistrafactura( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_FacturaId ,
                           ref DateTime aP2_FacturaFecha ,
                           ref String aP3_FacturaHora ,
                           ref short aP4_FacturaEstado ,
                           ref String aP5_FacturaSerie ,
                           ref int aP6_FacturaDocto ,
                           ref String aP7_ClienteCodigo ,
                           ref int aP8_ConsultaId ,
                           ref String aP9_FacturaCae1 ,
                           ref String aP10_FacturaCae2 ,
                           ref short aP11_Flag )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV8FacturaId = aP1_FacturaId;
         this.AV9FacturaFecha = aP2_FacturaFecha;
         this.AV10FacturaHora = aP3_FacturaHora;
         this.AV11FacturaEstado = aP4_FacturaEstado;
         this.AV15FacturaSerie = aP5_FacturaSerie;
         this.AV16FacturaDocto = aP6_FacturaDocto;
         this.AV17ClienteCodigo = aP7_ClienteCodigo;
         this.AV14ConsultaId = aP8_ConsultaId;
         this.AV20FacturaCae1 = aP9_FacturaCae1;
         this.AV21FacturaCae2 = aP10_FacturaCae2;
         this.AV22Flag = aP11_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.AV8FacturaId;
         aP2_FacturaFecha=this.AV9FacturaFecha;
         aP3_FacturaHora=this.AV10FacturaHora;
         aP4_FacturaEstado=this.AV11FacturaEstado;
         aP5_FacturaSerie=this.AV15FacturaSerie;
         aP6_FacturaDocto=this.AV16FacturaDocto;
         aP7_ClienteCodigo=this.AV17ClienteCodigo;
         aP8_ConsultaId=this.AV14ConsultaId;
         aP9_FacturaCae1=this.AV20FacturaCae1;
         aP10_FacturaCae2=this.AV21FacturaCae2;
         aP11_Flag=this.AV22Flag;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref int aP1_FacturaId ,
                               ref DateTime aP2_FacturaFecha ,
                               ref String aP3_FacturaHora ,
                               ref short aP4_FacturaEstado ,
                               ref String aP5_FacturaSerie ,
                               ref int aP6_FacturaDocto ,
                               ref String aP7_ClienteCodigo ,
                               ref int aP8_ConsultaId ,
                               ref String aP9_FacturaCae1 ,
                               ref String aP10_FacturaCae2 )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV8FacturaId = aP1_FacturaId;
         this.AV9FacturaFecha = aP2_FacturaFecha;
         this.AV10FacturaHora = aP3_FacturaHora;
         this.AV11FacturaEstado = aP4_FacturaEstado;
         this.AV15FacturaSerie = aP5_FacturaSerie;
         this.AV16FacturaDocto = aP6_FacturaDocto;
         this.AV17ClienteCodigo = aP7_ClienteCodigo;
         this.AV14ConsultaId = aP8_ConsultaId;
         this.AV20FacturaCae1 = aP9_FacturaCae1;
         this.AV21FacturaCae2 = aP10_FacturaCae2;
         this.AV22Flag = aP11_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.AV8FacturaId;
         aP2_FacturaFecha=this.AV9FacturaFecha;
         aP3_FacturaHora=this.AV10FacturaHora;
         aP4_FacturaEstado=this.AV11FacturaEstado;
         aP5_FacturaSerie=this.AV15FacturaSerie;
         aP6_FacturaDocto=this.AV16FacturaDocto;
         aP7_ClienteCodigo=this.AV17ClienteCodigo;
         aP8_ConsultaId=this.AV14ConsultaId;
         aP9_FacturaCae1=this.AV20FacturaCae1;
         aP10_FacturaCae2=this.AV21FacturaCae2;
         aP11_Flag=this.AV22Flag;
         return AV22Flag ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_FacturaId ,
                                 ref DateTime aP2_FacturaFecha ,
                                 ref String aP3_FacturaHora ,
                                 ref short aP4_FacturaEstado ,
                                 ref String aP5_FacturaSerie ,
                                 ref int aP6_FacturaDocto ,
                                 ref String aP7_ClienteCodigo ,
                                 ref int aP8_ConsultaId ,
                                 ref String aP9_FacturaCae1 ,
                                 ref String aP10_FacturaCae2 ,
                                 ref short aP11_Flag )
      {
         pregistrafactura objpregistrafactura;
         objpregistrafactura = new pregistrafactura();
         objpregistrafactura.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistrafactura.AV8FacturaId = aP1_FacturaId;
         objpregistrafactura.AV9FacturaFecha = aP2_FacturaFecha;
         objpregistrafactura.AV10FacturaHora = aP3_FacturaHora;
         objpregistrafactura.AV11FacturaEstado = aP4_FacturaEstado;
         objpregistrafactura.AV15FacturaSerie = aP5_FacturaSerie;
         objpregistrafactura.AV16FacturaDocto = aP6_FacturaDocto;
         objpregistrafactura.AV17ClienteCodigo = aP7_ClienteCodigo;
         objpregistrafactura.AV14ConsultaId = aP8_ConsultaId;
         objpregistrafactura.AV20FacturaCae1 = aP9_FacturaCae1;
         objpregistrafactura.AV21FacturaCae2 = aP10_FacturaCae2;
         objpregistrafactura.AV22Flag = aP11_Flag;
         objpregistrafactura.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistrafactura);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.AV8FacturaId;
         aP2_FacturaFecha=this.AV9FacturaFecha;
         aP3_FacturaHora=this.AV10FacturaHora;
         aP4_FacturaEstado=this.AV11FacturaEstado;
         aP5_FacturaSerie=this.AV15FacturaSerie;
         aP6_FacturaDocto=this.AV16FacturaDocto;
         aP7_ClienteCodigo=this.AV17ClienteCodigo;
         aP8_ConsultaId=this.AV14ConsultaId;
         aP9_FacturaCae1=this.AV20FacturaCae1;
         aP10_FacturaCae2=this.AV21FacturaCae2;
         aP11_Flag=this.AV22Flag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistrafactura)stateInfo).executePrivate();
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
         GXt_SdtParametros1 = AV18Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros1) ;
         AV18Parametros = GXt_SdtParametros1 ;
         AV19UsuarioCodigo = AV18Parametros.gxTpr_Pusuariocodigo ;
         AV13CajaCodigo = AV18Parametros.gxTpr_Pcajacodigo ;
         if ( AV22Flag == 1 )
         {
            /* Using cursor P000O2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A206ClinicaIva = P000O2_A206ClinicaIva[0] ;
               AV12FacturaIva = A206ClinicaIva ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            AV23FacturaFechaHora = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( AV9FacturaFecha)), (short)(DateTimeUtil.Month( AV9FacturaFecha)), (short)(DateTimeUtil.Day( AV9FacturaFecha)), (short)(NumberUtil.Val( StringUtil.Substring( AV10FacturaHora, 1, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( AV10FacturaHora, 4, 2), ".")), (short)(NumberUtil.Val( StringUtil.Substring( AV10FacturaHora, 7, 2), "."))) ;
            /*
               INSERT RECORD ON TABLE Factura

            */
            A185FacturaId = AV8FacturaId ;
            A186FacturaFecha = AV9FacturaFecha ;
            A187FacturaHora = AV10FacturaHora ;
            A188FacturaEstado = AV11FacturaEstado ;
            A178ClienteCodigo = AV17ClienteCodigo ;
            A189FacturaDocto = AV16FacturaDocto ;
            A190FacturaSerie = AV15FacturaSerie ;
            A191FacturaIva = AV12FacturaIva ;
            A192FacturaCae1 = AV20FacturaCae1 ;
            A229FacturaCae2 = AV21FacturaCae2 ;
            A132CajaCodigo = AV13CajaCodigo ;
            A91ConsultaId = AV14ConsultaId ;
            A4UsuarioCodigo = AV19UsuarioCodigo ;
            A280FacturaFechaHora = AV23FacturaFechaHora ;
            A281CorteCajaIdF = 0 ;
            /* Using cursor P000O3 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo, A185FacturaId, A186FacturaFecha, A187FacturaHora, A188FacturaEstado, A178ClienteCodigo, A189FacturaDocto, A190FacturaSerie, A191FacturaIva, A192FacturaCae1, A229FacturaCae2, A91ConsultaId, A132CajaCodigo, A280FacturaFechaHora, A4UsuarioCodigo, A281CorteCajaIdF});
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
            /* Using cursor P000O4 */
            pr_default.execute(2, new Object[] {A41ClinicaCodigo, AV14ConsultaId});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A162CargoId = P000O4_A162CargoId[0] ;
               A163CargoPrecio = P000O4_A163CargoPrecio[0] ;
               A164CargoCantidad = P000O4_A164CargoCantidad[0] ;
               A30ArticuloCodigo = P000O4_A30ArticuloCodigo[0] ;
               A91ConsultaId = P000O4_A91ConsultaId[0] ;
               /*
                  INSERT RECORD ON TABLE FacturaDetalle

               */
               W30ArticuloCodigo = A30ArticuloCodigo ;
               A185FacturaId = AV8FacturaId ;
               A248FacturaDId = A162CargoId ;
               A249FacturaDPrecio = A163CargoPrecio ;
               A250FacturaDCantidad = A164CargoCantidad ;
               /* Using cursor P000O5 */
               pr_default.execute(3, new Object[] {A41ClinicaCodigo, A185FacturaId, A248FacturaDId, A249FacturaDPrecio, A250FacturaDCantidad, A30ArticuloCodigo});
               pr_default.close(3);
               if ( (pr_default.getStatus(3) == 1) )
               {
                  context.Gx_err = 1 ;
                  Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
               }
               else
               {
                  context.Gx_err = 0 ;
                  Gx_emsg = "" ;
               }
               A30ArticuloCodigo = W30ArticuloCodigo ;
               /* End Insert */
               pr_default.readNext(2);
            }
            pr_default.close(2);
         }
         if ( AV22Flag == 2 )
         {
            /* Optimized UPDATE. */
            /* Using cursor P000O6 */
            pr_default.execute(4, new Object[] {AV16FacturaDocto, AV15FacturaSerie, AV11FacturaEstado, AV20FacturaCae1, AV21FacturaCae2, A41ClinicaCodigo, AV8FacturaId});
            pr_default.close(4);
            /* End optimized UPDATE. */
            /* Optimized UPDATE. */
            /* Using cursor P000O7 */
            pr_default.execute(5, new Object[] {A41ClinicaCodigo, AV14ConsultaId});
            pr_default.close(5);
            /* End optimized UPDATE. */
         }
         if ( AV22Flag == 3 )
         {
            /* Optimized UPDATE. */
            /* Using cursor P000O8 */
            pr_default.execute(6, new Object[] {AV11FacturaEstado, A41ClinicaCodigo, AV8FacturaId});
            pr_default.close(6);
            /* End optimized UPDATE. */
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pRegistraFactura");
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
         AV18Parametros = new SdtParametros(context);
         GXt_SdtParametros1 = new SdtParametros(context);
         AV19UsuarioCodigo = "" ;
         AV13CajaCodigo = "" ;
         scmdbuf = "" ;
         P000O2_A41ClinicaCodigo = new String[] {""} ;
         P000O2_A206ClinicaIva = new decimal[1] ;
         AV23FacturaFechaHora = (DateTime)(DateTime.MinValue) ;
         A186FacturaFecha = DateTime.MinValue ;
         A187FacturaHora = "" ;
         A178ClienteCodigo = "" ;
         A190FacturaSerie = "" ;
         A192FacturaCae1 = "" ;
         A229FacturaCae2 = "" ;
         A132CajaCodigo = "" ;
         A4UsuarioCodigo = "" ;
         A280FacturaFechaHora = (DateTime)(DateTime.MinValue) ;
         Gx_emsg = "" ;
         P000O4_A41ClinicaCodigo = new String[] {""} ;
         P000O4_A162CargoId = new int[1] ;
         P000O4_A163CargoPrecio = new decimal[1] ;
         P000O4_A164CargoCantidad = new decimal[1] ;
         P000O4_A30ArticuloCodigo = new String[] {""} ;
         P000O4_A91ConsultaId = new int[1] ;
         A30ArticuloCodigo = "" ;
         W30ArticuloCodigo = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistrafactura__default(),
            new Object[][] {
                new Object[] {
               P000O2_A41ClinicaCodigo, P000O2_A206ClinicaIva
               }
               , new Object[] {
               }
               , new Object[] {
               P000O4_A41ClinicaCodigo, P000O4_A162CargoId, P000O4_A163CargoPrecio, P000O4_A164CargoCantidad, P000O4_A30ArticuloCodigo, P000O4_A91ConsultaId
               }
               , new Object[] {
               }
               , new Object[] {
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

      private short AV11FacturaEstado ;
      private short AV22Flag ;
      private short A188FacturaEstado ;
      private int AV8FacturaId ;
      private int AV16FacturaDocto ;
      private int AV14ConsultaId ;
      private int GX_INS49 ;
      private int A185FacturaId ;
      private int A189FacturaDocto ;
      private int A91ConsultaId ;
      private int A281CorteCajaIdF ;
      private int A162CargoId ;
      private int GX_INS60 ;
      private int A248FacturaDId ;
      private decimal A206ClinicaIva ;
      private decimal AV12FacturaIva ;
      private decimal A191FacturaIva ;
      private decimal A163CargoPrecio ;
      private decimal A164CargoCantidad ;
      private decimal A249FacturaDPrecio ;
      private decimal A250FacturaDCantidad ;
      private String AV10FacturaHora ;
      private String scmdbuf ;
      private String A187FacturaHora ;
      private String Gx_emsg ;
      private DateTime AV23FacturaFechaHora ;
      private DateTime A280FacturaFechaHora ;
      private DateTime AV9FacturaFecha ;
      private DateTime A186FacturaFecha ;
      private String A41ClinicaCodigo ;
      private String AV15FacturaSerie ;
      private String AV17ClienteCodigo ;
      private String AV20FacturaCae1 ;
      private String AV21FacturaCae2 ;
      private String AV19UsuarioCodigo ;
      private String AV13CajaCodigo ;
      private String A178ClienteCodigo ;
      private String A190FacturaSerie ;
      private String A192FacturaCae1 ;
      private String A229FacturaCae2 ;
      private String A132CajaCodigo ;
      private String A4UsuarioCodigo ;
      private String A30ArticuloCodigo ;
      private String W30ArticuloCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_FacturaId ;
      private DateTime aP2_FacturaFecha ;
      private String aP3_FacturaHora ;
      private short aP4_FacturaEstado ;
      private String aP5_FacturaSerie ;
      private int aP6_FacturaDocto ;
      private String aP7_ClienteCodigo ;
      private int aP8_ConsultaId ;
      private String aP9_FacturaCae1 ;
      private String aP10_FacturaCae2 ;
      private short aP11_Flag ;
      private IDataStoreProvider pr_default ;
      private String[] P000O2_A41ClinicaCodigo ;
      private decimal[] P000O2_A206ClinicaIva ;
      private String[] P000O4_A41ClinicaCodigo ;
      private int[] P000O4_A162CargoId ;
      private decimal[] P000O4_A163CargoPrecio ;
      private decimal[] P000O4_A164CargoCantidad ;
      private String[] P000O4_A30ArticuloCodigo ;
      private int[] P000O4_A91ConsultaId ;
      private SdtParametros AV18Parametros ;
      private SdtParametros GXt_SdtParametros1 ;
   }

   public class pregistrafactura__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new UpdateCursor(def[4])
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000O2 ;
          prmP000O2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP000O3 ;
          prmP000O3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@FacturaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@FacturaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClienteCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaDocto",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@FacturaIva",SqlDbType.Decimal,17,2} ,
          new Object[] {"@FacturaCae1",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@FacturaCae2",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaFechaHora",SqlDbType.DateTime,8,5} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaIdF",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000O4 ;
          prmP000O4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV14ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000O5 ;
          prmP000O5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDId",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaDPrecio",SqlDbType.Decimal,17,2} ,
          new Object[] {"@FacturaDCantidad",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP000O6 ;
          prmP000O6 = new Object[] {
          new Object[] {"@FacturaDocto",SqlDbType.Int,9,0} ,
          new Object[] {"@FacturaSerie",SqlDbType.VarChar,20,0} ,
          new Object[] {"@FacturaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@FacturaCae1",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@FacturaCae2",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000O7 ;
          prmP000O7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV14ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000O8 ;
          prmP000O8 = new Object[] {
          new Object[] {"@FacturaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8FacturaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000O2", "SELECT [ClinicaCodigo], [ClinicaIva] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000O2,1,0,false,true )
             ,new CursorDef("P000O3", "INSERT INTO [Factura] ([ClinicaCodigo], [FacturaId], [FacturaFecha], [FacturaHora], [FacturaEstado], [ClienteCodigo], [FacturaDocto], [FacturaSerie], [FacturaIva], [FacturaCae1], [FacturaCae2], [ConsultaId], [CajaCodigo], [FacturaFechaHora], [UsuarioCodigo], [CorteCajaIdF]) VALUES (@ClinicaCodigo, @FacturaId, @FacturaFecha, @FacturaHora, @FacturaEstado, @ClienteCodigo, @FacturaDocto, @FacturaSerie, @FacturaIva, @FacturaCae1, @FacturaCae2, @ConsultaId, @CajaCodigo, @FacturaFechaHora, @UsuarioCodigo, @CorteCajaIdF)", GxErrorMask.GX_NOMASK,prmP000O3)
             ,new CursorDef("P000O4", "SELECT [ClinicaCodigo], [CargoId], [CargoPrecio], [CargoCantidad], [ArticuloCodigo], [ConsultaId] FROM [Cargo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] = @AV14ConsultaId ORDER BY [ClinicaCodigo], [ConsultaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000O4,100,0,true,false )
             ,new CursorDef("P000O5", "INSERT INTO [FacturaDetalle] ([ClinicaCodigo], [FacturaId], [FacturaDId], [FacturaDPrecio], [FacturaDCantidad], [ArticuloCodigo]) VALUES (@ClinicaCodigo, @FacturaId, @FacturaDId, @FacturaDPrecio, @FacturaDCantidad, @ArticuloCodigo)", GxErrorMask.GX_NOMASK,prmP000O5)
             ,new CursorDef("P000O6", "UPDATE [Factura] SET [FacturaDocto]=@FacturaDocto, [FacturaSerie]=@FacturaSerie, [FacturaEstado]=@FacturaEstado, [FacturaCae1]=@FacturaCae1, [FacturaCae2]=@FacturaCae2  WHERE [ClinicaCodigo] = @ClinicaCodigo and [FacturaId] = @AV8FacturaId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000O6)
             ,new CursorDef("P000O7", "UPDATE [Consulta] SET [ConsultaEstado]=3  WHERE [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] = @AV14ConsultaId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000O7)
             ,new CursorDef("P000O8", "UPDATE [Factura] SET [FacturaEstado]=@FacturaEstado  WHERE [ClinicaCodigo] = @ClinicaCodigo and [FacturaId] = @AV8FacturaId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000O8)
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
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (decimal)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (int)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (DateTime)parms[13]);
                stmt.SetParameter(15, (String)parms[14]);
                stmt.SetParameter(16, (int)parms[15]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 4 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
       }
    }

 }

}
