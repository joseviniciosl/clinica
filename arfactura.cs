/*
               File: rFactura
        Description: Impresión de Factura
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:47.71
       Program type: Main program
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
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class arfactura : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
   {
      public override void webExecute( )
      {
         context.SetTheme("Fantastic");
         initialize();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            GxWebError = 1 ;
            context.HttpContext.Response.StatusDescription = 403.ToString();
            context.WriteHtmlText( "<title>403 Forbidden</title>") ;
            context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
            context.WriteHtmlText( "<p /><hr />") ;
         }
         if ( ( GxWebError == 0 ) && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXDecQS = Crypto.Decrypt64( context.GetRequestQueryString( ), GXKey) ;
            if ( StringUtil.StrCmp(StringUtil.Right( GXDecQS, 6), Crypto.CheckSum( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), 6)) == 0 )
            {
               SetQueryString( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6))) ;
            }
            else
            {
               GxWebError = 1 ;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
            }
         }
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            if ( ! entryPointCalled )
            {
               A41ClinicaCodigo = gxfirstwebparm ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  A185FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               }
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public arfactura( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public arfactura( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_FacturaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A185FacturaId = aP1_FacturaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
      }

      public int executeUdp( ref String aP0_ClinicaCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A185FacturaId = aP1_FacturaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
         return A185FacturaId ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_FacturaId )
      {
         arfactura objarfactura;
         objarfactura = new arfactura();
         objarfactura.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objarfactura.A185FacturaId = aP1_FacturaId;
         objarfactura.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objarfactura);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_FacturaId=this.A185FacturaId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((arfactura)stateInfo).executePrivate();
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
         M_top = 0 ;
         M_bot = 6 ;
         P_lines = (int)(66-M_bot) ;
         getPrinter().GxClearAttris() ;
         add_metrics( ) ;
         lineHeight = 15 ;
         PrtOffset = 0 ;
         gxXPage = 100 ;
         gxYPage = 100 ;
         getPrinter().GxSetDocName("") ;
         try
         {
            Gx_out = "SCR" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 256, 16834, 11909, 0, 1, 1, 0, 1, 1) )
            {
               cleanup();
               return;
            }
            getPrinter().setModal(false) ;
            P_lines = (int)(gxYPage-(lineHeight*6)) ;
            Gx_line = (int)(P_lines+1) ;
            getPrinter().setPageLines(P_lines);
            getPrinter().setLineHeight(lineHeight);
            getPrinter().setM_top(M_top);
            getPrinter().setM_bot(M_bot);
            /* Using cursor P000T2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A185FacturaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A91ConsultaId = P000T2_A91ConsultaId[0] ;
               A188FacturaEstado = P000T2_A188FacturaEstado[0] ;
               A67PacienteId = P000T2_A67PacienteId[0] ;
               A182ClienteDireccion = P000T2_A182ClienteDireccion[0] ;
               A179ClienteNombre = P000T2_A179ClienteNombre[0] ;
               A178ClienteCodigo = P000T2_A178ClienteCodigo[0] ;
               A189FacturaDocto = P000T2_A189FacturaDocto[0] ;
               A190FacturaSerie = P000T2_A190FacturaSerie[0] ;
               A186FacturaFecha = P000T2_A186FacturaFecha[0] ;
               A67PacienteId = P000T2_A67PacienteId[0] ;
               A182ClienteDireccion = P000T2_A182ClienteDireccion[0] ;
               A179ClienteNombre = P000T2_A179ClienteNombre[0] ;
               H0T0( false, 150) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Fecha", 25, Gx_line+17, 57, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Serie", 258, Gx_line+17, 284, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("Factura", 442, Gx_line+17, 481, Gx_line+32, 0+256) ;
               getPrinter().GxDrawText("NIT", 25, Gx_line+33, 45, Gx_line+48, 0+256) ;
               getPrinter().GxDrawText("Nombre", 25, Gx_line+50, 65, Gx_line+65, 0+256) ;
               getPrinter().GxDrawText("Dirección", 25, Gx_line+67, 73, Gx_line+82, 0+256) ;
               getPrinter().GxDrawText("Paciente", 25, Gx_line+83, 70, Gx_line+98, 0+256) ;
               getPrinter().GxDrawText("Descripción", 75, Gx_line+117, 134, Gx_line+132, 0+256) ;
               getPrinter().GxDrawText("Cantidad", 458, Gx_line+117, 503, Gx_line+132, 0+256) ;
               getPrinter().GxDrawText("Precio", 617, Gx_line+117, 649, Gx_line+132, 0+256) ;
               getPrinter().GxDrawText("Total", 750, Gx_line+117, 776, Gx_line+132, 0+256) ;
               getPrinter().GxDrawText(context.localUtil.Format( A186FacturaFecha, "99/99/99"), 92, Gx_line+17, 141, Gx_line+33, 2+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A190FacturaSerie, "")), 300, Gx_line+17, 405, Gx_line+33, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A189FacturaDocto), "ZZZZZZZZ9")), 517, Gx_line+17, 574, Gx_line+33, 2+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A178ClienteCodigo, "")), 92, Gx_line+33, 145, Gx_line+49, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A179ClienteNombre, "")), 92, Gx_line+50, 614, Gx_line+66, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A182ClienteDireccion, "")), 92, Gx_line+67, 718, Gx_line+83, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9")), 92, Gx_line+83, 149, Gx_line+99, 2+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+150) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            /* Using cursor P000T3 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo, A185FacturaId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A30ArticuloCodigo = P000T3_A30ArticuloCodigo[0] ;
               A248FacturaDId = P000T3_A248FacturaDId[0] ;
               A31ArticuloDescripcion = P000T3_A31ArticuloDescripcion[0] ;
               A250FacturaDCantidad = P000T3_A250FacturaDCantidad[0] ;
               A249FacturaDPrecio = P000T3_A249FacturaDPrecio[0] ;
               A31ArticuloDescripcion = P000T3_A31ArticuloDescripcion[0] ;
               A251FacturaDTotal = (decimal)(A249FacturaDPrecio*A250FacturaDCantidad) ;
               H0T0( false, 24) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A31ArticuloDescripcion, "")), 67, Gx_line+0, 589, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A250FacturaDCantidad, "ZZZZZZZZZZZZZ9.99")), 417, Gx_line+0, 524, Gx_line+16, 2+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A249FacturaDPrecio, "ZZZZZZZZZZZZZ9.99")), 575, Gx_line+0, 682, Gx_line+16, 2+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A251FacturaDTotal, "ZZZZZZZZZZZZZ9.99")), 708, Gx_line+0, 815, Gx_line+16, 2+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+24) ;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            H0T0( false, 77) ;
            getPrinter().GxDrawLine(700, Gx_line+17, 817, Gx_line+17, 1, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A247FacturaTotal, "ZZZZZZZZZZZZZ9.99")), 708, Gx_line+33, 815, Gx_line+49, 2+256) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+77) ;
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H0T0( true, 0) ;
         }
         catch ( GeneXus.Printer.ProcessInterruptedException e )
         {
         }
         finally
         {
            /* Close printer file */
            try
            {
               getPrinter().GxEndPage() ;
               getPrinter().GxEndDocument() ;
            }
            catch ( GeneXus.Printer.ProcessInterruptedException e )
            {
            }
            endPrinter();
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
         {
            context.Redirect( context.wjLoc );
            context.wjLoc = "" ;
         }
         this.cleanup();
      }

      protected void H0T0( bool bFoot ,
                           int Inc )
      {
         /* Skip the required number of lines */
         while ( ( ToSkip > 0 ) || ( Gx_line + Inc > P_lines ) )
         {
            if ( Gx_line + Inc >= P_lines )
            {
               if ( Gx_page > 0 )
               {
                  /* Print footers */
                  Gx_line = P_lines ;
                  getPrinter().GxEndPage() ;
                  if ( bFoot )
                  {
                     return  ;
                  }
               }
               ToSkip = 0 ;
               Gx_line = 0 ;
               Gx_page = (int)(Gx_page+1) ;
               /* Skip Margin Top Lines */
               Gx_line = (int)(Gx_line+(M_top*lineHeight)) ;
               /* Print headers */
               getPrinter().GxStartPage() ;
               if (true) break;
            }
            else
            {
               PrtOffset = 0 ;
               context.skipLines( 1 );
               Gx_line = (int)(Gx_line+1) ;
            }
            ToSkip = (int)(ToSkip-1) ;
         }
         getPrinter().setPage(Gx_page);
      }

      protected void add_metrics( )
      {
         add_metrics0( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 36, 48, 14, 36, 21, 64, 36, 36, 21, 64, 43, 21, 64, 48, 39, 48, 48, 14, 14, 21, 21, 22, 36, 64, 20, 64, 32, 21, 60, 48, 31, 43, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      public override int getOutputType( )
      {
         return GxReportUtils.OUTPUT_PDF ;
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if (IsMain)	waitPrinterEnd();
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
         GXKey = "" ;
         GXDecQS = "" ;
         gxfirstwebparm = "" ;
         scmdbuf = "" ;
         P000T2_A91ConsultaId = new int[1] ;
         P000T2_A41ClinicaCodigo = new String[] {""} ;
         P000T2_A185FacturaId = new int[1] ;
         P000T2_A188FacturaEstado = new short[1] ;
         P000T2_A67PacienteId = new int[1] ;
         P000T2_A182ClienteDireccion = new String[] {""} ;
         P000T2_A179ClienteNombre = new String[] {""} ;
         P000T2_A178ClienteCodigo = new String[] {""} ;
         P000T2_A189FacturaDocto = new int[1] ;
         P000T2_A190FacturaSerie = new String[] {""} ;
         P000T2_A186FacturaFecha = new DateTime[] {DateTime.MinValue} ;
         A182ClienteDireccion = "" ;
         A179ClienteNombre = "" ;
         A178ClienteCodigo = "" ;
         A190FacturaSerie = "" ;
         A186FacturaFecha = DateTime.MinValue ;
         P000T3_A30ArticuloCodigo = new String[] {""} ;
         P000T3_A41ClinicaCodigo = new String[] {""} ;
         P000T3_A185FacturaId = new int[1] ;
         P000T3_A248FacturaDId = new int[1] ;
         P000T3_A31ArticuloDescripcion = new String[] {""} ;
         P000T3_A250FacturaDCantidad = new decimal[1] ;
         P000T3_A249FacturaDPrecio = new decimal[1] ;
         A30ArticuloCodigo = "" ;
         A31ArticuloDescripcion = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.arfactura__default(),
            new Object[][] {
                new Object[] {
               P000T2_A91ConsultaId, P000T2_A41ClinicaCodigo, P000T2_A185FacturaId, P000T2_A188FacturaEstado, P000T2_A67PacienteId, P000T2_A182ClienteDireccion, P000T2_A179ClienteNombre, P000T2_A178ClienteCodigo, P000T2_A189FacturaDocto, P000T2_A190FacturaSerie,
               P000T2_A186FacturaFecha
               }
               , new Object[] {
               P000T3_A30ArticuloCodigo, P000T3_A41ClinicaCodigo, P000T3_A185FacturaId, P000T3_A248FacturaDId, P000T3_A31ArticuloDescripcion, P000T3_A250FacturaDCantidad, P000T3_A249FacturaDPrecio
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short GxWebError ;
      private short nGotPars ;
      private short A188FacturaEstado ;
      private int A185FacturaId ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A91ConsultaId ;
      private int A67PacienteId ;
      private int A189FacturaDocto ;
      private int Gx_OldLine ;
      private int A248FacturaDId ;
      private decimal A250FacturaDCantidad ;
      private decimal A249FacturaDPrecio ;
      private decimal A251FacturaDTotal ;
      private decimal A247FacturaTotal ;
      private String GXKey ;
      private String GXDecQS ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private DateTime A186FacturaFecha ;
      private bool entryPointCalled ;
      private String A41ClinicaCodigo ;
      private String A182ClienteDireccion ;
      private String A179ClienteNombre ;
      private String A178ClienteCodigo ;
      private String A190FacturaSerie ;
      private String A30ArticuloCodigo ;
      private String A31ArticuloDescripcion ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_FacturaId ;
      private IDataStoreProvider pr_default ;
      private int[] P000T2_A91ConsultaId ;
      private String[] P000T2_A41ClinicaCodigo ;
      private int[] P000T2_A185FacturaId ;
      private short[] P000T2_A188FacturaEstado ;
      private int[] P000T2_A67PacienteId ;
      private String[] P000T2_A182ClienteDireccion ;
      private String[] P000T2_A179ClienteNombre ;
      private String[] P000T2_A178ClienteCodigo ;
      private int[] P000T2_A189FacturaDocto ;
      private String[] P000T2_A190FacturaSerie ;
      private DateTime[] P000T2_A186FacturaFecha ;
      private String[] P000T3_A30ArticuloCodigo ;
      private String[] P000T3_A41ClinicaCodigo ;
      private int[] P000T3_A185FacturaId ;
      private int[] P000T3_A248FacturaDId ;
      private String[] P000T3_A31ArticuloDescripcion ;
      private decimal[] P000T3_A250FacturaDCantidad ;
      private decimal[] P000T3_A249FacturaDPrecio ;
   }

   public class arfactura__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000T2 ;
          prmP000T2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000T3 ;
          prmP000T3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@FacturaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000T2", "SELECT T1.[ConsultaId], T1.[ClinicaCodigo], T1.[FacturaId], T1.[FacturaEstado], T2.[PacienteId], T3.[ClienteDireccion], T3.[ClienteNombre], T1.[ClienteCodigo], T1.[FacturaDocto], T1.[FacturaSerie], T1.[FacturaFecha] FROM (([Factura] T1 WITH (NOLOCK) INNER JOIN [Consulta] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[ConsultaId] = T1.[ConsultaId]) INNER JOIN [Cliente] T3 WITH (NOLOCK) ON T3.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T3.[ClienteCodigo] = T1.[ClienteCodigo]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[FacturaId] = @FacturaId ORDER BY T1.[ClinicaCodigo], T1.[FacturaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000T2,1,0,false,true )
             ,new CursorDef("P000T3", "SELECT T1.[ArticuloCodigo], T1.[ClinicaCodigo], T1.[FacturaId], T1.[FacturaDId], T2.[ArticuloDescripcion], T1.[FacturaDCantidad], T1.[FacturaDPrecio] FROM ([FacturaDetalle] T1 WITH (NOLOCK) INNER JOIN [Articulo] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[ArticuloCodigo] = T1.[ArticuloCodigo]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[FacturaId] = @FacturaId ORDER BY T1.[ClinicaCodigo], T1.[FacturaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000T3,100,0,false,false )
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((int[]) buf[8])[0] = rslt.getInt(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(11) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
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
                break;
       }
    }

 }

}
