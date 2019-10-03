/*
               File: rPartidaContable
        Description: Impresión de Partida Contable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:59.4
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
   public class arpartidacontable : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
                  A199TipoParCodigo = GetNextPar( ) ;
                  A207PartidaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               }
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public arpartidacontable( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public arpartidacontable( IGxContext context )
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
                           ref int aP2_PartidaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
      }

      public int executeUdp( ref String aP0_ClinicaCodigo ,
                             ref String aP1_TipoParCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A199TipoParCodigo = aP1_TipoParCodigo;
         this.A207PartidaId = aP2_PartidaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
         return A207PartidaId ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref String aP1_TipoParCodigo ,
                                 ref int aP2_PartidaId )
      {
         arpartidacontable objarpartidacontable;
         objarpartidacontable = new arpartidacontable();
         objarpartidacontable.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objarpartidacontable.A199TipoParCodigo = aP1_TipoParCodigo;
         objarpartidacontable.A207PartidaId = aP2_PartidaId;
         objarpartidacontable.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objarpartidacontable);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_TipoParCodigo=this.A199TipoParCodigo;
         aP2_PartidaId=this.A207PartidaId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((arpartidacontable)stateInfo).executePrivate();
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
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 1, 15840, 12240, 0, 1, 1, 0, 1, 1) )
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
            /* Using cursor P001C2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A200TipoParNombre = P001C2_A200TipoParNombre[0] ;
               A212PartidaReferencia = P001C2_A212PartidaReferencia[0] ;
               A209PartidaHora = P001C2_A209PartidaHora[0] ;
               A208PartidaFecha = P001C2_A208PartidaFecha[0] ;
               A43ClinicaNit = P001C2_A43ClinicaNit[0] ;
               A42ClinicaNombre = P001C2_A42ClinicaNombre[0] ;
               A43ClinicaNit = P001C2_A43ClinicaNit[0] ;
               A42ClinicaNombre = P001C2_A42ClinicaNombre[0] ;
               A200TipoParNombre = P001C2_A200TipoParNombre[0] ;
               H1C0( false, 148) ;
               getPrinter().GxDrawLine(8, Gx_line+133, 841, Gx_line+133, 1, 0, 0, 0, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("No.", 11, Gx_line+117, 35, Gx_line+134, 0+256) ;
               getPrinter().GxDrawText("Cuenta", 50, Gx_line+117, 98, Gx_line+134, 0+256) ;
               getPrinter().GxDrawText("Descripción", 150, Gx_line+117, 230, Gx_line+134, 0+256) ;
               getPrinter().GxDrawText("Debe", 619, Gx_line+117, 655, Gx_line+134, 0+256) ;
               getPrinter().GxDrawText("Haber", 749, Gx_line+117, 791, Gx_line+134, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A207PartidaId), "ZZZZZZZZ9")), 108, Gx_line+50, 208, Gx_line+69, 0) ;
               getPrinter().GxDrawText(context.localUtil.Format( A208PartidaFecha, "99/99/99"), 317, Gx_line+50, 417, Gx_line+69, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A209PartidaHora, "XXXXXXXX")), 500, Gx_line+50, 609, Gx_line+69, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A212PartidaReferencia, "")), 108, Gx_line+83, 359, Gx_line+102, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A199TipoParCodigo, "")), 108, Gx_line+67, 172, Gx_line+86, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A200TipoParNombre, "")), 192, Gx_line+67, 631, Gx_line+86, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Partida Id", 17, Gx_line+50, 88, Gx_line+68, 0+256) ;
               getPrinter().GxDrawText("Fecha", 250, Gx_line+50, 296, Gx_line+68, 0+256) ;
               getPrinter().GxDrawText("Hora", 450, Gx_line+50, 486, Gx_line+68, 0+256) ;
               getPrinter().GxDrawText("Tipo", 17, Gx_line+67, 51, Gx_line+85, 0+256) ;
               getPrinter().GxDrawText("Referencia", 17, Gx_line+83, 97, Gx_line+101, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A42ClinicaNombre, "")), 17, Gx_line+0, 542, Gx_line+18, 0) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A43ClinicaNit, "")), 17, Gx_line+17, 185, Gx_line+38, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+148) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            AV8PartidaDebeT = 0 ;
            AV9PartidaHaberT = 0 ;
            /* Using cursor P001C3 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A194CtaContableNombre = P001C3_A194CtaContableNombre[0] ;
               A193CtaContableCodigo = P001C3_A193CtaContableCodigo[0] ;
               A216PartidaHaber = P001C3_A216PartidaHaber[0] ;
               A215PartidaDebe = P001C3_A215PartidaDebe[0] ;
               A214PartidaLinea = P001C3_A214PartidaLinea[0] ;
               A194CtaContableNombre = P001C3_A194CtaContableNombre[0] ;
               H1C0( false, 24) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(A214PartidaLinea), "ZZZ9")), 8, Gx_line+0, 38, Gx_line+18, 2+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A215PartidaDebe, "ZZZZZZZZZZZZZ9.99")), 575, Gx_line+0, 700, Gx_line+18, 2+256) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A216PartidaHaber, "ZZZZZZZZZZZZZ9.99")), 708, Gx_line+0, 833, Gx_line+18, 2+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A193CtaContableCodigo, "")), 50, Gx_line+0, 103, Gx_line+18, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A194CtaContableNombre, "")), 125, Gx_line+0, 543, Gx_line+18, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+24) ;
               AV8PartidaDebeT = (decimal)(AV8PartidaDebeT+A215PartidaDebe) ;
               AV9PartidaHaberT = (decimal)(AV9PartidaHaberT+A216PartidaHaber) ;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            H1C0( false, 24) ;
            getPrinter().GxAttris("Microsoft Sans Serif", 10, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("Total", 500, Gx_line+0, 539, Gx_line+18, 0+256) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( AV8PartidaDebeT, "ZZZZZZZZZZZZZ9.99")), 575, Gx_line+0, 700, Gx_line+18, 2) ;
            getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( AV9PartidaHaberT, "ZZZZZZZZZZZZZ9.99")), 708, Gx_line+0, 833, Gx_line+18, 2) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+24) ;
            /* Using cursor P001C4 */
            pr_default.execute(2, new Object[] {A41ClinicaCodigo, A199TipoParCodigo, A207PartidaId});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A210PartidaObs = P001C4_A210PartidaObs[0] ;
               A5UsuarioNombre = P001C4_A5UsuarioNombre[0] ;
               A4UsuarioCodigo = P001C4_A4UsuarioCodigo[0] ;
               A5UsuarioNombre = P001C4_A5UsuarioNombre[0] ;
               H1C0( false, 101) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A4UsuarioCodigo, "")), 142, Gx_line+17, 206, Gx_line+36, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A5UsuarioNombre, "")), 208, Gx_line+17, 834, Gx_line+36, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A210PartidaObs, "")), 142, Gx_line+33, 834, Gx_line+84, 0) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Usuario", 17, Gx_line+17, 74, Gx_line+35, 0+256) ;
               getPrinter().GxDrawText("Observaciones", 17, Gx_line+33, 127, Gx_line+51, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+101) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(2);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H1C0( true, 0) ;
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

      protected void H1C0( bool bFoot ,
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
         add_metrics1( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 34, 47, 17, 34, 31, 62, 34, 34, 21, 64, 41, 21, 62, 47, 38, 47, 47, 17, 17, 31, 31, 22, 34, 62, 20, 62, 34, 21, 59, 47, 31, 41, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
      }

      protected void add_metrics1( )
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
         P001C2_A41ClinicaCodigo = new String[] {""} ;
         P001C2_A199TipoParCodigo = new String[] {""} ;
         P001C2_A207PartidaId = new int[1] ;
         P001C2_A200TipoParNombre = new String[] {""} ;
         P001C2_A212PartidaReferencia = new String[] {""} ;
         P001C2_A209PartidaHora = new String[] {""} ;
         P001C2_A208PartidaFecha = new DateTime[] {DateTime.MinValue} ;
         P001C2_A43ClinicaNit = new String[] {""} ;
         P001C2_A42ClinicaNombre = new String[] {""} ;
         A200TipoParNombre = "" ;
         A212PartidaReferencia = "" ;
         A209PartidaHora = "" ;
         A208PartidaFecha = DateTime.MinValue ;
         A43ClinicaNit = "" ;
         A42ClinicaNombre = "" ;
         P001C3_A41ClinicaCodigo = new String[] {""} ;
         P001C3_A199TipoParCodigo = new String[] {""} ;
         P001C3_A207PartidaId = new int[1] ;
         P001C3_A194CtaContableNombre = new String[] {""} ;
         P001C3_A193CtaContableCodigo = new String[] {""} ;
         P001C3_A216PartidaHaber = new decimal[1] ;
         P001C3_A215PartidaDebe = new decimal[1] ;
         P001C3_A214PartidaLinea = new short[1] ;
         A194CtaContableNombre = "" ;
         A193CtaContableCodigo = "" ;
         P001C4_A41ClinicaCodigo = new String[] {""} ;
         P001C4_A199TipoParCodigo = new String[] {""} ;
         P001C4_A207PartidaId = new int[1] ;
         P001C4_A210PartidaObs = new String[] {""} ;
         P001C4_A5UsuarioNombre = new String[] {""} ;
         P001C4_A4UsuarioCodigo = new String[] {""} ;
         A210PartidaObs = "" ;
         A5UsuarioNombre = "" ;
         A4UsuarioCodigo = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.arpartidacontable__default(),
            new Object[][] {
                new Object[] {
               P001C2_A41ClinicaCodigo, P001C2_A199TipoParCodigo, P001C2_A207PartidaId, P001C2_A200TipoParNombre, P001C2_A212PartidaReferencia, P001C2_A209PartidaHora, P001C2_A208PartidaFecha, P001C2_A43ClinicaNit, P001C2_A42ClinicaNombre
               }
               , new Object[] {
               P001C3_A41ClinicaCodigo, P001C3_A199TipoParCodigo, P001C3_A207PartidaId, P001C3_A194CtaContableNombre, P001C3_A193CtaContableCodigo, P001C3_A216PartidaHaber, P001C3_A215PartidaDebe, P001C3_A214PartidaLinea
               }
               , new Object[] {
               P001C4_A41ClinicaCodigo, P001C4_A199TipoParCodigo, P001C4_A207PartidaId, P001C4_A210PartidaObs, P001C4_A5UsuarioNombre, P001C4_A4UsuarioCodigo
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short GxWebError ;
      private short nGotPars ;
      private short A214PartidaLinea ;
      private int A207PartidaId ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private decimal AV8PartidaDebeT ;
      private decimal AV9PartidaHaberT ;
      private decimal A216PartidaHaber ;
      private decimal A215PartidaDebe ;
      private String GXKey ;
      private String GXDecQS ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private String A209PartidaHora ;
      private DateTime A208PartidaFecha ;
      private bool entryPointCalled ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String A200TipoParNombre ;
      private String A212PartidaReferencia ;
      private String A43ClinicaNit ;
      private String A42ClinicaNombre ;
      private String A194CtaContableNombre ;
      private String A193CtaContableCodigo ;
      private String A210PartidaObs ;
      private String A5UsuarioNombre ;
      private String A4UsuarioCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private String aP1_TipoParCodigo ;
      private int aP2_PartidaId ;
      private IDataStoreProvider pr_default ;
      private String[] P001C2_A41ClinicaCodigo ;
      private String[] P001C2_A199TipoParCodigo ;
      private int[] P001C2_A207PartidaId ;
      private String[] P001C2_A200TipoParNombre ;
      private String[] P001C2_A212PartidaReferencia ;
      private String[] P001C2_A209PartidaHora ;
      private DateTime[] P001C2_A208PartidaFecha ;
      private String[] P001C2_A43ClinicaNit ;
      private String[] P001C2_A42ClinicaNombre ;
      private String[] P001C3_A41ClinicaCodigo ;
      private String[] P001C3_A199TipoParCodigo ;
      private int[] P001C3_A207PartidaId ;
      private String[] P001C3_A194CtaContableNombre ;
      private String[] P001C3_A193CtaContableCodigo ;
      private decimal[] P001C3_A216PartidaHaber ;
      private decimal[] P001C3_A215PartidaDebe ;
      private short[] P001C3_A214PartidaLinea ;
      private String[] P001C4_A41ClinicaCodigo ;
      private String[] P001C4_A199TipoParCodigo ;
      private int[] P001C4_A207PartidaId ;
      private String[] P001C4_A210PartidaObs ;
      private String[] P001C4_A5UsuarioNombre ;
      private String[] P001C4_A4UsuarioCodigo ;
   }

   public class arpartidacontable__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001C2 ;
          prmP001C2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP001C3 ;
          prmP001C3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP001C4 ;
          prmP001C4 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PartidaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001C2", "SELECT T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId], T3.[TipoParNombre], T1.[PartidaReferencia], T1.[PartidaHora], T1.[PartidaFecha], T2.[ClinicaNit], T2.[ClinicaNombre] FROM (([PartidaEnc] T1 WITH (NOLOCK) INNER JOIN [Clinica] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo]) INNER JOIN [TipoPartida] T3 WITH (NOLOCK) ON T3.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T3.[TipoParCodigo] = T1.[TipoParCodigo]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[TipoParCodigo] = @TipoParCodigo and T1.[PartidaId] = @PartidaId ORDER BY T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001C2,1,0,false,true )
             ,new CursorDef("P001C3", "SELECT T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId], T2.[CtaContableNombre], T1.[CtaContableCodigo], T1.[PartidaHaber], T1.[PartidaDebe], T1.[PartidaLinea] FROM ([PartidaDet] T1 WITH (NOLOCK) INNER JOIN [CuentaContable] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[CtaContableCodigo] = T1.[CtaContableCodigo]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[TipoParCodigo] = @TipoParCodigo and T1.[PartidaId] = @PartidaId ORDER BY T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001C3,100,0,false,false )
             ,new CursorDef("P001C4", "SELECT T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId], T1.[PartidaObs], T2.[UsuarioNombre], T1.[UsuarioCodigo] FROM ([PartidaEnc] T1 WITH (NOLOCK) INNER JOIN [Usuario] T2 WITH (NOLOCK) ON T2.[UsuarioCodigo] = T1.[UsuarioCodigo]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[TipoParCodigo] = @TipoParCodigo and T1.[PartidaId] = @PartidaId ORDER BY T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001C4,1,0,false,true )
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
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 8) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDate(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                break;
       }
    }

 }

}
