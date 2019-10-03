/*
               File: pCalculaCorteCaja
        Description: Calcula Corte de Caja
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:49.30
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
   public class pcalculacortecaja : GXProcedure
   {
      public pcalculacortecaja( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pcalculacortecaja( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref String aP1_CajaCodigo ,
                           ref int aP2_CorteCajaId ,
                           ref DateTime aP3_CorteCajaFechaD ,
                           ref DateTime aP4_CorteCajaFechaA ,
                           ref String aP5_UsuarioCodigo ,
                           ref short aP6_Flag )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A132CajaCodigo = aP1_CajaCodigo;
         this.AV9CorteCajaId = aP2_CorteCajaId;
         this.AV10CorteCajaFechaD = aP3_CorteCajaFechaD;
         this.AV11CorteCajaFechaA = aP4_CorteCajaFechaA;
         this.AV8UsuarioCodigo = aP5_UsuarioCodigo;
         this.AV12Flag = aP6_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_CajaCodigo=this.A132CajaCodigo;
         aP2_CorteCajaId=this.AV9CorteCajaId;
         aP3_CorteCajaFechaD=this.AV10CorteCajaFechaD;
         aP4_CorteCajaFechaA=this.AV11CorteCajaFechaA;
         aP5_UsuarioCodigo=this.AV8UsuarioCodigo;
         aP6_Flag=this.AV12Flag;
      }

      public short executeUdp( ref String aP0_ClinicaCodigo ,
                               ref String aP1_CajaCodigo ,
                               ref int aP2_CorteCajaId ,
                               ref DateTime aP3_CorteCajaFechaD ,
                               ref DateTime aP4_CorteCajaFechaA ,
                               ref String aP5_UsuarioCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A132CajaCodigo = aP1_CajaCodigo;
         this.AV9CorteCajaId = aP2_CorteCajaId;
         this.AV10CorteCajaFechaD = aP3_CorteCajaFechaD;
         this.AV11CorteCajaFechaA = aP4_CorteCajaFechaA;
         this.AV8UsuarioCodigo = aP5_UsuarioCodigo;
         this.AV12Flag = aP6_Flag;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_CajaCodigo=this.A132CajaCodigo;
         aP2_CorteCajaId=this.AV9CorteCajaId;
         aP3_CorteCajaFechaD=this.AV10CorteCajaFechaD;
         aP4_CorteCajaFechaA=this.AV11CorteCajaFechaA;
         aP5_UsuarioCodigo=this.AV8UsuarioCodigo;
         aP6_Flag=this.AV12Flag;
         return AV12Flag ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_CajaCodigo ,
                                 ref int aP2_CorteCajaId ,
                                 ref DateTime aP3_CorteCajaFechaD ,
                                 ref DateTime aP4_CorteCajaFechaA ,
                                 ref String aP5_UsuarioCodigo ,
                                 ref short aP6_Flag )
      {
         pcalculacortecaja objpcalculacortecaja;
         objpcalculacortecaja = new pcalculacortecaja();
         objpcalculacortecaja.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objpcalculacortecaja.A132CajaCodigo = aP1_CajaCodigo;
         objpcalculacortecaja.AV9CorteCajaId = aP2_CorteCajaId;
         objpcalculacortecaja.AV10CorteCajaFechaD = aP3_CorteCajaFechaD;
         objpcalculacortecaja.AV11CorteCajaFechaA = aP4_CorteCajaFechaA;
         objpcalculacortecaja.AV8UsuarioCodigo = aP5_UsuarioCodigo;
         objpcalculacortecaja.AV12Flag = aP6_Flag;
         objpcalculacortecaja.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpcalculacortecaja);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_CajaCodigo=this.A132CajaCodigo;
         aP2_CorteCajaId=this.AV9CorteCajaId;
         aP3_CorteCajaFechaD=this.AV10CorteCajaFechaD;
         aP4_CorteCajaFechaA=this.AV11CorteCajaFechaA;
         aP5_UsuarioCodigo=this.AV8UsuarioCodigo;
         aP6_Flag=this.AV12Flag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pcalculacortecaja)stateInfo).executePrivate();
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
         if ( AV12Flag == 1 )
         {
            GXt_int1 = AV9CorteCajaId ;
            new oobtienecorrelativocortecaja(context ).execute(  A41ClinicaCodigo,  A132CajaCodigo, out  GXt_int1) ;
            AV9CorteCajaId = GXt_int1 ;
            /*
               INSERT RECORD ON TABLE CorteCaja

            */
            A153CorteCajaId = AV9CorteCajaId ;
            A4UsuarioCodigo = AV8UsuarioCodigo ;
            A279CorteCajaFechaA = AV11CorteCajaFechaA ;
            A278CorteCajaFechaD = AV10CorteCajaFechaD ;
            /* Using cursor P000V2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId, A4UsuarioCodigo, A278CorteCajaFechaD, A279CorteCajaFechaA});
            pr_default.close(0);
            if ( (pr_default.getStatus(0) == 1) )
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
            /* Using cursor P000V3 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A65FormaPagoCodigo = P000V3_A65FormaPagoCodigo[0] ;
               A66FormaPagoNombre = P000V3_A66FormaPagoNombre[0] ;
               /*
                  INSERT RECORD ON TABLE CorteCajaDet

               */
               A153CorteCajaId = AV9CorteCajaId ;
               A156CorteCajaValor = 0 ;
               /* Using cursor P000V4 */
               pr_default.execute(2, new Object[] {A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId, A65FormaPagoCodigo, A156CorteCajaValor});
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
               /* End Insert */
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         /* Using cursor P000V5 */
         pr_default.execute(3, new Object[] {A41ClinicaCodigo, A132CajaCodigo, AV9CorteCajaId});
         while ( (pr_default.getStatus(3) != 101) )
         {
            A153CorteCajaId = P000V5_A153CorteCajaId[0] ;
            A65FormaPagoCodigo = P000V5_A65FormaPagoCodigo[0] ;
            A156CorteCajaValor = P000V5_A156CorteCajaValor[0] ;
            AV13FormaPagoCodigo = A65FormaPagoCodigo ;
            AV14CorteCajaValor = 0 ;
            /* Execute user subroutine: S1132 */
            S1132 ();
            if ( returnInSub )
            {
               pr_default.close(3);
               this.cleanup();
               if (true) return;
            }
            A156CorteCajaValor = AV14CorteCajaValor ;
            /* Using cursor P000V6 */
            pr_default.execute(4, new Object[] {A156CorteCajaValor, A41ClinicaCodigo, A132CajaCodigo, A153CorteCajaId, A65FormaPagoCodigo});
            pr_default.close(4);
            pr_default.readNext(3);
         }
         pr_default.close(3);
         this.cleanup();
      }

      protected void S1132( )
      {
         /* 'VALIDA FORMA PAGO' Routine */
         /* Using cursor P000V7 */
         pr_default.execute(5, new Object[] {A41ClinicaCodigo, AV13FormaPagoCodigo, AV10CorteCajaFechaD, AV11CorteCajaFechaA});
         while ( (pr_default.getStatus(5) != 101) )
         {
            A185FacturaId = P000V7_A185FacturaId[0] ;
            A65FormaPagoCodigo = P000V7_A65FormaPagoCodigo[0] ;
            A280FacturaFechaHora = P000V7_A280FacturaFechaHora[0] ;
            A188FacturaEstado = P000V7_A188FacturaEstado[0] ;
            A261FacturaPMonto = P000V7_A261FacturaPMonto[0] ;
            A281CorteCajaIdF = P000V7_A281CorteCajaIdF[0] ;
            A260FacturaPId = P000V7_A260FacturaPId[0] ;
            A280FacturaFechaHora = P000V7_A280FacturaFechaHora[0] ;
            A188FacturaEstado = P000V7_A188FacturaEstado[0] ;
            A281CorteCajaIdF = P000V7_A281CorteCajaIdF[0] ;
            AV14CorteCajaValor = (decimal)(AV14CorteCajaValor+A261FacturaPMonto) ;
            A281CorteCajaIdF = AV9CorteCajaId ;
            /* Using cursor P000V8 */
            pr_default.execute(6, new Object[] {A281CorteCajaIdF, A41ClinicaCodigo, A185FacturaId});
            pr_default.close(6);
            pr_default.readNext(5);
         }
         pr_default.close(5);
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pCalculaCorteCaja");
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
         A4UsuarioCodigo = "" ;
         A279CorteCajaFechaA = (DateTime)(DateTime.MinValue) ;
         A278CorteCajaFechaD = (DateTime)(DateTime.MinValue) ;
         Gx_emsg = "" ;
         scmdbuf = "" ;
         P000V3_A41ClinicaCodigo = new String[] {""} ;
         P000V3_A65FormaPagoCodigo = new String[] {""} ;
         P000V3_A66FormaPagoNombre = new String[] {""} ;
         A65FormaPagoCodigo = "" ;
         A66FormaPagoNombre = "" ;
         P000V5_A41ClinicaCodigo = new String[] {""} ;
         P000V5_A132CajaCodigo = new String[] {""} ;
         P000V5_A153CorteCajaId = new int[1] ;
         P000V5_A65FormaPagoCodigo = new String[] {""} ;
         P000V5_A156CorteCajaValor = new decimal[1] ;
         AV13FormaPagoCodigo = "" ;
         P000V7_A185FacturaId = new int[1] ;
         P000V7_A41ClinicaCodigo = new String[] {""} ;
         P000V7_A65FormaPagoCodigo = new String[] {""} ;
         P000V7_A280FacturaFechaHora = new DateTime[] {DateTime.MinValue} ;
         P000V7_A188FacturaEstado = new short[1] ;
         P000V7_A261FacturaPMonto = new decimal[1] ;
         P000V7_A281CorteCajaIdF = new int[1] ;
         P000V7_A260FacturaPId = new int[1] ;
         A280FacturaFechaHora = (DateTime)(DateTime.MinValue) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pcalculacortecaja__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               P000V3_A41ClinicaCodigo, P000V3_A65FormaPagoCodigo, P000V3_A66FormaPagoNombre
               }
               , new Object[] {
               }
               , new Object[] {
               P000V5_A41ClinicaCodigo, P000V5_A132CajaCodigo, P000V5_A153CorteCajaId, P000V5_A65FormaPagoCodigo, P000V5_A156CorteCajaValor
               }
               , new Object[] {
               }
               , new Object[] {
               P000V7_A185FacturaId, P000V7_A41ClinicaCodigo, P000V7_A65FormaPagoCodigo, P000V7_A280FacturaFechaHora, P000V7_A188FacturaEstado, P000V7_A261FacturaPMonto, P000V7_A281CorteCajaIdF, P000V7_A260FacturaPId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV12Flag ;
      private short A188FacturaEstado ;
      private int AV9CorteCajaId ;
      private int GXt_int1 ;
      private int GX_INS43 ;
      private int A153CorteCajaId ;
      private int GX_INS44 ;
      private int A185FacturaId ;
      private int A281CorteCajaIdF ;
      private int A260FacturaPId ;
      private decimal A156CorteCajaValor ;
      private decimal AV14CorteCajaValor ;
      private decimal A261FacturaPMonto ;
      private String Gx_emsg ;
      private String scmdbuf ;
      private DateTime AV10CorteCajaFechaD ;
      private DateTime AV11CorteCajaFechaA ;
      private DateTime A279CorteCajaFechaA ;
      private DateTime A278CorteCajaFechaD ;
      private DateTime A280FacturaFechaHora ;
      private bool returnInSub ;
      private String A41ClinicaCodigo ;
      private String A132CajaCodigo ;
      private String AV8UsuarioCodigo ;
      private String A4UsuarioCodigo ;
      private String A65FormaPagoCodigo ;
      private String A66FormaPagoNombre ;
      private String AV13FormaPagoCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_CajaCodigo ;
      private int aP2_CorteCajaId ;
      private DateTime aP3_CorteCajaFechaD ;
      private DateTime aP4_CorteCajaFechaA ;
      private String aP5_UsuarioCodigo ;
      private short aP6_Flag ;
      private IDataStoreProvider pr_default ;
      private String[] P000V3_A41ClinicaCodigo ;
      private String[] P000V3_A65FormaPagoCodigo ;
      private String[] P000V3_A66FormaPagoNombre ;
      private String[] P000V5_A41ClinicaCodigo ;
      private String[] P000V5_A132CajaCodigo ;
      private int[] P000V5_A153CorteCajaId ;
      private String[] P000V5_A65FormaPagoCodigo ;
      private decimal[] P000V5_A156CorteCajaValor ;
      private int[] P000V7_A185FacturaId ;
      private String[] P000V7_A41ClinicaCodigo ;
      private String[] P000V7_A65FormaPagoCodigo ;
      private DateTime[] P000V7_A280FacturaFechaHora ;
      private short[] P000V7_A188FacturaEstado ;
      private decimal[] P000V7_A261FacturaPMonto ;
      private int[] P000V7_A281CorteCajaIdF ;
      private int[] P000V7_A260FacturaPId ;
   }

   public class pcalculacortecaja__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new UpdateCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new UpdateCursor(def[6])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000V2 ;
          prmP000V2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaFechaD",SqlDbType.DateTime,8,5} ,
          new Object[] {"@CorteCajaFechaA",SqlDbType.DateTime,8,5}
          } ;
          Object[] prmP000V3 ;
          prmP000V3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP000V4 ;
          prmP000V4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaValor",SqlDbType.Decimal,17,2}
          } ;
          Object[] prmP000V5 ;
          prmP000V5 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV9CorteCajaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000V6 ;
          prmP000V6 = new Object[] {
          new Object[] {"@CorteCajaValor",SqlDbType.Decimal,17,2} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@CorteCajaId",SqlDbType.Int,9,0} ,
          new Object[] {"@FormaPagoCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP000V7 ;
          prmP000V7 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV13FormaPagoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV10CorteCajaFechaD",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AV11CorteCajaFechaA",SqlDbType.DateTime,8,5}
          } ;
          Object[] prmP000V8 ;
          prmP000V8 = new Object[] {
          new Object[] {"@CorteCajaIdF",SqlDbType.Int,9,0} ,
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000V2", "INSERT INTO [CorteCaja] ([ClinicaCodigo], [CajaCodigo], [CorteCajaId], [UsuarioCodigo], [CorteCajaFechaD], [CorteCajaFechaA]) VALUES (@ClinicaCodigo, @CajaCodigo, @CorteCajaId, @UsuarioCodigo, @CorteCajaFechaD, @CorteCajaFechaA)", GxErrorMask.GX_NOMASK,prmP000V2)
             ,new CursorDef("P000V3", "SELECT [ClinicaCodigo], [FormaPagoCodigo], [FormaPagoNombre] FROM [FormaPago] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000V3,100,0,true,false )
             ,new CursorDef("P000V4", "INSERT INTO [CorteCajaDet] ([ClinicaCodigo], [CajaCodigo], [CorteCajaId], [FormaPagoCodigo], [CorteCajaValor]) VALUES (@ClinicaCodigo, @CajaCodigo, @CorteCajaId, @FormaPagoCodigo, @CorteCajaValor)", GxErrorMask.GX_NOMASK,prmP000V4)
             ,new CursorDef("P000V5", "SELECT [ClinicaCodigo], [CajaCodigo], [CorteCajaId], [FormaPagoCodigo], [CorteCajaValor] FROM [CorteCajaDet] WITH (UPDLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [CajaCodigo] = @CajaCodigo and [CorteCajaId] = @AV9CorteCajaId ORDER BY [ClinicaCodigo], [CajaCodigo], [CorteCajaId] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000V5,1,0,true,false )
             ,new CursorDef("P000V6", "UPDATE [CorteCajaDet] SET [CorteCajaValor]=@CorteCajaValor  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [CajaCodigo] = @CajaCodigo AND [CorteCajaId] = @CorteCajaId AND [FormaPagoCodigo] = @FormaPagoCodigo", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000V6)
             ,new CursorDef("P000V7", "SELECT T1.[FacturaId], T1.[ClinicaCodigo], T1.[FormaPagoCodigo], T2.[FacturaFechaHora], T2.[FacturaEstado], T1.[FacturaPMonto], T2.[CorteCajaIdF], T1.[FacturaPId] FROM ([FacturaPago] T1 WITH (NOLOCK) INNER JOIN [Factura] T2 WITH (UPDLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[FacturaId] = T1.[FacturaId]) WHERE (T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[FormaPagoCodigo] = @AV13FormaPagoCodigo) AND (T2.[FacturaFechaHora] >= @AV10CorteCajaFechaD) AND (T2.[FacturaFechaHora] <= @AV11CorteCajaFechaA) AND (T2.[FacturaEstado] = 1) ORDER BY T1.[ClinicaCodigo], T1.[FormaPagoCodigo] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000V7,1,0,true,false )
             ,new CursorDef("P000V8", "UPDATE [Factura] SET [CorteCajaIdF]=@CorteCajaIdF  WHERE [ClinicaCodigo] = @ClinicaCodigo AND [FacturaId] = @FacturaId", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000V8)
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                break;
             case 5 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
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
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
             case 4 :
                stmt.SetParameter(1, (decimal)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
             case 5 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                break;
       }
    }

 }

}
