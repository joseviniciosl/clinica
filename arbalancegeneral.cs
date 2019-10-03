/*
               File: rBalanceGeneral
        Description: Reporte de Balance General
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:59.97
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
   public class arbalancegeneral : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
               AV8ClinicaCodigo = gxfirstwebparm ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11Anio = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV10Mes = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  AV12Tipo = GetNextPar( ) ;
                  AV9UsuarioCodigo = GetNextPar( ) ;
               }
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public arbalancegeneral( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public arbalancegeneral( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref short aP1_Anio ,
                           ref short aP2_Mes ,
                           ref String aP3_Tipo ,
                           ref String aP4_UsuarioCodigo )
      {
         this.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV11Anio = aP1_Anio;
         this.AV10Mes = aP2_Mes;
         this.AV12Tipo = aP3_Tipo;
         this.AV9UsuarioCodigo = aP4_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_Anio=this.AV11Anio;
         aP2_Mes=this.AV10Mes;
         aP3_Tipo=this.AV12Tipo;
         aP4_UsuarioCodigo=this.AV9UsuarioCodigo;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref short aP1_Anio ,
                                ref short aP2_Mes ,
                                ref String aP3_Tipo )
      {
         this.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV11Anio = aP1_Anio;
         this.AV10Mes = aP2_Mes;
         this.AV12Tipo = aP3_Tipo;
         this.AV9UsuarioCodigo = aP4_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_Anio=this.AV11Anio;
         aP2_Mes=this.AV10Mes;
         aP3_Tipo=this.AV12Tipo;
         aP4_UsuarioCodigo=this.AV9UsuarioCodigo;
         return AV9UsuarioCodigo ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref short aP1_Anio ,
                                 ref short aP2_Mes ,
                                 ref String aP3_Tipo ,
                                 ref String aP4_UsuarioCodigo )
      {
         arbalancegeneral objarbalancegeneral;
         objarbalancegeneral = new arbalancegeneral();
         objarbalancegeneral.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         objarbalancegeneral.AV11Anio = aP1_Anio;
         objarbalancegeneral.AV10Mes = aP2_Mes;
         objarbalancegeneral.AV12Tipo = aP3_Tipo;
         objarbalancegeneral.AV9UsuarioCodigo = aP4_UsuarioCodigo;
         objarbalancegeneral.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objarbalancegeneral);
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_Anio=this.AV11Anio;
         aP2_Mes=this.AV10Mes;
         aP3_Tipo=this.AV12Tipo;
         aP4_UsuarioCodigo=this.AV9UsuarioCodigo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((arbalancegeneral)stateInfo).executePrivate();
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
            AV13SQLString = " @ClinicaCodigo = '" + AV8ClinicaCodigo + "', @Anio = '" + StringUtil.Trim( StringUtil.Str( (decimal)(AV11Anio), 10, 0)) + "', @Mes = '" + StringUtil.Trim( StringUtil.Str( (decimal)(AV10Mes), 10, 0)) + "', @Tipo = '" + AV12Tipo + "', @UsuarioCodigo = '" + AV9UsuarioCodigo + "' " ;
            /* User SQL Command. */
            cmdBuffer = " execute SP_RepBalanceGeneral " + AV13SQLString ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            context.CommitDataStores("rBalanceGeneral");
            GXt_char1 = AV14NombreMes ;
            new oobtienenombremes(context ).execute(  AV10Mes, out  GXt_char1) ;
            AV14NombreMes = GXt_char1 ;
            /* Using cursor P001D2 */
            pr_default.execute(0, new Object[] {AV8ClinicaCodigo});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A41ClinicaCodigo = P001D2_A41ClinicaCodigo[0] ;
               A43ClinicaNit = P001D2_A43ClinicaNit[0] ;
               A42ClinicaNombre = P001D2_A42ClinicaNombre[0] ;
               H1D0( false, 157) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Cuenta", 8, Gx_line+133, 51, Gx_line+148, 0+256) ;
               getPrinter().GxDrawText("Nombre", 92, Gx_line+133, 138, Gx_line+148, 0+256) ;
               getPrinter().GxDrawText("Nivel 5", 392, Gx_line+133, 435, Gx_line+148, 0+256) ;
               getPrinter().GxDrawText("Nivel 4", 483, Gx_line+133, 526, Gx_line+148, 0+256) ;
               getPrinter().GxDrawText("Nivel 3", 575, Gx_line+133, 618, Gx_line+148, 0+256) ;
               getPrinter().GxDrawText("Nivel 2", 667, Gx_line+133, 710, Gx_line+148, 0+256) ;
               getPrinter().GxDrawText("Nivel 1", 758, Gx_line+133, 801, Gx_line+148, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV14NombreMes, "")), 75, Gx_line+83, 183, Gx_line+102, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11Anio), "ZZZ9")), 183, Gx_line+83, 225, Gx_line+102, 2) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 10, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("Fecha", 17, Gx_line+83, 63, Gx_line+101, 0+256) ;
               getPrinter().GxDrawText("Tipo", 17, Gx_line+100, 51, Gx_line+118, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 11, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A42ClinicaNombre, "")), 17, Gx_line+0, 851, Gx_line+21, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A43ClinicaNit, "")), 17, Gx_line+17, 185, Gx_line+38, 0+256) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 16, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("BALANCE GENERAL", 317, Gx_line+50, 546, Gx_line+77, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+157) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            /* Using cursor P001D3 */
            pr_default.execute(1, new Object[] {AV8ClinicaCodigo, AV9UsuarioCodigo});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A4UsuarioCodigo = P001D3_A4UsuarioCodigo[0] ;
               A41ClinicaCodigo = P001D3_A41ClinicaCodigo[0] ;
               A308RBENivel1 = P001D3_A308RBENivel1[0] ;
               n308RBENivel1 = P001D3_n308RBENivel1[0] ;
               A309RBENivel2 = P001D3_A309RBENivel2[0] ;
               n309RBENivel2 = P001D3_n309RBENivel2[0] ;
               A310RBENivel3 = P001D3_A310RBENivel3[0] ;
               n310RBENivel3 = P001D3_n310RBENivel3[0] ;
               A311RBENivel4 = P001D3_A311RBENivel4[0] ;
               n311RBENivel4 = P001D3_n311RBENivel4[0] ;
               A312RBENivel5 = P001D3_A312RBENivel5[0] ;
               n312RBENivel5 = P001D3_n312RBENivel5[0] ;
               A303RBECtaContableNombre = P001D3_A303RBECtaContableNombre[0] ;
               A302RBECtaContableCodigo = P001D3_A302RBECtaContableCodigo[0] ;
               H1D0( false, 24) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A302RBECtaContableCodigo, "")), 8, Gx_line+0, 61, Gx_line+16, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A303RBECtaContableNombre, "")), 75, Gx_line+0, 358, Gx_line+16, 0) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A312RBENivel5, "ZZZZZZZZZZZZZ9.99")), 367, Gx_line+0, 450, Gx_line+16, 2) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A311RBENivel4, "ZZZZZZZZZZZZZ9.99")), 458, Gx_line+0, 541, Gx_line+16, 2) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A310RBENivel3, "ZZZZZZZZZZZZZ9.99")), 550, Gx_line+0, 633, Gx_line+16, 2) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A309RBENivel2, "ZZZZZZZZZZZZZ9.99")), 642, Gx_line+0, 725, Gx_line+16, 2) ;
               getPrinter().GxDrawText(StringUtil.LTrim( context.localUtil.Format( A308RBENivel1, "ZZZZZZZZZZZZZ9.99")), 733, Gx_line+0, 816, Gx_line+16, 2) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+24) ;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H1D0( true, 0) ;
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

      protected void H1D0( bool bFoot ,
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
         AV13SQLString = "" ;
         cmdBuffer = "" ;
         AV14NombreMes = "" ;
         GXt_char1 = "" ;
         scmdbuf = "" ;
         P001D2_A41ClinicaCodigo = new String[] {""} ;
         P001D2_A43ClinicaNit = new String[] {""} ;
         P001D2_A42ClinicaNombre = new String[] {""} ;
         A41ClinicaCodigo = "" ;
         A43ClinicaNit = "" ;
         A42ClinicaNombre = "" ;
         P001D3_A4UsuarioCodigo = new String[] {""} ;
         P001D3_A41ClinicaCodigo = new String[] {""} ;
         P001D3_A308RBENivel1 = new decimal[1] ;
         P001D3_n308RBENivel1 = new bool[] {false} ;
         P001D3_A309RBENivel2 = new decimal[1] ;
         P001D3_n309RBENivel2 = new bool[] {false} ;
         P001D3_A310RBENivel3 = new decimal[1] ;
         P001D3_n310RBENivel3 = new bool[] {false} ;
         P001D3_A311RBENivel4 = new decimal[1] ;
         P001D3_n311RBENivel4 = new bool[] {false} ;
         P001D3_A312RBENivel5 = new decimal[1] ;
         P001D3_n312RBENivel5 = new bool[] {false} ;
         P001D3_A303RBECtaContableNombre = new String[] {""} ;
         P001D3_A302RBECtaContableCodigo = new String[] {""} ;
         A4UsuarioCodigo = "" ;
         A303RBECtaContableNombre = "" ;
         A302RBECtaContableCodigo = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.arbalancegeneral__default(),
            new Object[][] {
                new Object[] {
               P001D2_A41ClinicaCodigo, P001D2_A43ClinicaNit, P001D2_A42ClinicaNombre
               }
               , new Object[] {
               P001D3_A4UsuarioCodigo, P001D3_A41ClinicaCodigo, P001D3_A308RBENivel1, P001D3_n308RBENivel1, P001D3_A309RBENivel2, P001D3_n309RBENivel2, P001D3_A310RBENivel3, P001D3_n310RBENivel3, P001D3_A311RBENivel4, P001D3_n311RBENivel4,
               P001D3_A312RBENivel5, P001D3_n312RBENivel5, P001D3_A303RBECtaContableNombre, P001D3_A302RBECtaContableCodigo
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short GxWebError ;
      private short nGotPars ;
      private short AV11Anio ;
      private short AV10Mes ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int Gx_OldLine ;
      private decimal A308RBENivel1 ;
      private decimal A309RBENivel2 ;
      private decimal A310RBENivel3 ;
      private decimal A311RBENivel4 ;
      private decimal A312RBENivel5 ;
      private String GXKey ;
      private String GXDecQS ;
      private String gxfirstwebparm ;
      private String cmdBuffer ;
      private String GXt_char1 ;
      private String scmdbuf ;
      private bool entryPointCalled ;
      private bool n308RBENivel1 ;
      private bool n309RBENivel2 ;
      private bool n310RBENivel3 ;
      private bool n311RBENivel4 ;
      private bool n312RBENivel5 ;
      private String AV8ClinicaCodigo ;
      private String AV12Tipo ;
      private String AV9UsuarioCodigo ;
      private String AV13SQLString ;
      private String AV14NombreMes ;
      private String A41ClinicaCodigo ;
      private String A43ClinicaNit ;
      private String A42ClinicaNombre ;
      private String A4UsuarioCodigo ;
      private String A303RBECtaContableNombre ;
      private String A302RBECtaContableCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private short aP1_Anio ;
      private short aP2_Mes ;
      private String aP3_Tipo ;
      private String aP4_UsuarioCodigo ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
      private String[] P001D2_A41ClinicaCodigo ;
      private String[] P001D2_A43ClinicaNit ;
      private String[] P001D2_A42ClinicaNombre ;
      private String[] P001D3_A4UsuarioCodigo ;
      private String[] P001D3_A41ClinicaCodigo ;
      private decimal[] P001D3_A308RBENivel1 ;
      private bool[] P001D3_n308RBENivel1 ;
      private decimal[] P001D3_A309RBENivel2 ;
      private bool[] P001D3_n309RBENivel2 ;
      private decimal[] P001D3_A310RBENivel3 ;
      private bool[] P001D3_n310RBENivel3 ;
      private decimal[] P001D3_A311RBENivel4 ;
      private bool[] P001D3_n311RBENivel4 ;
      private decimal[] P001D3_A312RBENivel5 ;
      private bool[] P001D3_n312RBENivel5 ;
      private String[] P001D3_A303RBECtaContableNombre ;
      private String[] P001D3_A302RBECtaContableCodigo ;
   }

   public class arbalancegeneral__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001D2 ;
          prmP001D2 = new Object[] {
          new Object[] {"@AV8ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmP001D3 ;
          prmP001D3 = new Object[] {
          new Object[] {"@AV8ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV9UsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001D2", "SELECT [ClinicaCodigo], [ClinicaNit], [ClinicaNombre] FROM [Clinica] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV8ClinicaCodigo ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D2,1,0,false,true )
             ,new CursorDef("P001D3", "SELECT [UsuarioCodigo], [ClinicaCodigo], [RBENivel1], [RBENivel2], [RBENivel3], [RBENivel4], [RBENivel5], [RBECtaContableNombre], [RBECtaContableCodigo] FROM [RepBalanceEstado] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV8ClinicaCodigo) AND ([UsuarioCodigo] = @AV9UsuarioCodigo) ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001D3,100,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((decimal[]) buf[4])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(5);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(6);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(7);
                ((String[]) buf[12])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(9) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
