/*
               File: rRecetaMedica
        Description: Reporte de receta médica
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:41.14
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
   public class arrecetamedica : GXWebProcedure, System.Web.SessionState.IRequiresSessionState
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
                  A91ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               }
            }
         }
         if ( GxWebError == 0 )
         {
            executePrivate();
         }
         cleanup();
      }

      public arrecetamedica( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public arrecetamedica( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_ConsultaId )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
      }

      public int executeUdp( ref String aP0_ClinicaCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A91ConsultaId = aP1_ConsultaId;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
         return A91ConsultaId ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_ConsultaId )
      {
         arrecetamedica objarrecetamedica;
         objarrecetamedica = new arrecetamedica();
         objarrecetamedica.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objarrecetamedica.A91ConsultaId = aP1_ConsultaId;
         objarrecetamedica.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objarrecetamedica);
         aP0_ClinicaCodigo=this.A41ClinicaCodigo;
         aP1_ConsultaId=this.A91ConsultaId;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((arrecetamedica)stateInfo).executePrivate();
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
            Gx_out = "FIL" ;
            if (!initPrinter (Gx_out, gxXPage, gxYPage, "GXPRN.INI", "", "", 2, 1, 256, 12240, 7848, 0, 1, 1, 0, 1, 1) )
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
            /* Using cursor P000H2 */
            pr_default.execute(0, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A19MedicoCodigo = P000H2_A19MedicoCodigo[0] ;
               n19MedicoCodigo = P000H2_n19MedicoCodigo[0] ;
               A67PacienteId = P000H2_A67PacienteId[0] ;
               A159ConsultaEstado = P000H2_A159ConsultaEstado[0] ;
               A71PacienteApellido2 = P000H2_A71PacienteApellido2[0] ;
               A70PacienteApellido1 = P000H2_A70PacienteApellido1[0] ;
               A69PacienteNombre2 = P000H2_A69PacienteNombre2[0] ;
               A68PacienteNombre1 = P000H2_A68PacienteNombre1[0] ;
               A21MedicoColegiado = P000H2_A21MedicoColegiado[0] ;
               A93ConsultaHora = P000H2_A93ConsultaHora[0] ;
               A20MedicoNombre = P000H2_A20MedicoNombre[0] ;
               A92ConsultaFecha = P000H2_A92ConsultaFecha[0] ;
               A53ClinicaLogo = P000H2_A53ClinicaLogo[0] ;
               A53ClinicaLogo = P000H2_A53ClinicaLogo[0] ;
               A21MedicoColegiado = P000H2_A21MedicoColegiado[0] ;
               A20MedicoNombre = P000H2_A20MedicoNombre[0] ;
               A71PacienteApellido2 = P000H2_A71PacienteApellido2[0] ;
               A70PacienteApellido1 = P000H2_A70PacienteApellido1[0] ;
               A69PacienteNombre2 = P000H2_A69PacienteNombre2[0] ;
               A68PacienteNombre1 = P000H2_A68PacienteNombre1[0] ;
               AV8Paciente = StringUtil.Trim( A68PacienteNombre1) + " " + StringUtil.Trim( A69PacienteNombre2) + " " + StringUtil.Trim( A70PacienteApellido1) + " " + StringUtil.Trim( A71PacienteApellido2) ;
               H0H0( false, 183) ;
               getPrinter().GxAttris("Microsoft Sans Serif", 8, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A53ClinicaLogo, "")), 217, Gx_line+0, 292, Gx_line+51, 0) ;
               getPrinter().GxAttris("Microsoft YaHei UI", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(context.localUtil.Format( A92ConsultaFecha, "99/99/99"), 125, Gx_line+67, 217, Gx_line+85, 2) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A20MedicoNombre, "")), 125, Gx_line+83, 751, Gx_line+101, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( AV8Paciente, "")), 125, Gx_line+117, 751, Gx_line+135, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A93ConsultaHora, "XXXXXXXX")), 233, Gx_line+67, 334, Gx_line+85, 0+256) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A21MedicoColegiado, "")), 125, Gx_line+100, 189, Gx_line+118, 0+256) ;
               getPrinter().GxAttris("Microsoft YaHei UI", 9, true, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText("FECHA:", 25, Gx_line+67, 72, Gx_line+84, 0+256) ;
               getPrinter().GxDrawText("MÉDICO:", 25, Gx_line+83, 82, Gx_line+100, 0+256) ;
               getPrinter().GxDrawText("PACIENTE:", 25, Gx_line+117, 93, Gx_line+134, 0+256) ;
               getPrinter().GxDrawText("COLEGIADO:", 25, Gx_line+100, 106, Gx_line+117, 0+256) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+183) ;
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            /* Using cursor P000H3 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo, A91ConsultaId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A109RecetaId = P000H3_A109RecetaId[0] ;
               A112RecetaObs = P000H3_A112RecetaObs[0] ;
               H0H0( false, 33) ;
               getPrinter().GxAttris("Microsoft YaHei UI", 10, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
               getPrinter().GxDrawText(StringUtil.RTrim( context.localUtil.Format( A112RecetaObs, "")), 8, Gx_line+0, 533, Gx_line+20, 0) ;
               Gx_OldLine = Gx_line ;
               Gx_line = (int)(Gx_line+33) ;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            H0H0( false, 127) ;
            getPrinter().GxDrawLine(150, Gx_line+50, 392, Gx_line+50, 1, 0, 0, 0, 0) ;
            getPrinter().GxAttris("Microsoft YaHei UI", 9, false, false, false, false, 0, 0, 0, 0, 0, 255, 255, 255) ;
            getPrinter().GxDrawText("* Señor farmacéutico, despachar los productos arriba indicados.", 17, Gx_line+83, 411, Gx_line+100, 0+256) ;
            getPrinter().GxDrawText("* Siga las instrucciones de esta receta, no abandone el tratamiento.", 17, Gx_line+100, 427, Gx_line+117, 0+256) ;
            getPrinter().GxDrawText("FIRMA Y SELLO MÉDICO", 200, Gx_line+50, 350, Gx_line+67, 0+256) ;
            Gx_OldLine = Gx_line ;
            Gx_line = (int)(Gx_line+127) ;
            /* Print footer for last page */
            ToSkip = (int)(P_lines+1) ;
            H0H0( true, 0) ;
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

      protected void H0H0( bool bFoot ,
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
         add_metrics2( ) ;
      }

      protected void add_metrics0( )
      {
         getPrinter().setMetrics("Microsoft Sans Serif", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 36, 48, 14, 36, 21, 64, 36, 36, 21, 64, 43, 21, 64, 48, 39, 48, 48, 14, 14, 21, 21, 22, 36, 64, 20, 64, 32, 21, 60, 48, 31, 43, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      protected void add_metrics1( )
      {
         getPrinter().setMetrics("Microsoft YaHei UI", false, false, 58, 14, 72, 171,  new int[] {48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 48, 18, 20, 23, 36, 36, 57, 43, 12, 21, 21, 25, 37, 18, 21, 18, 18, 36, 36, 36, 36, 36, 36, 36, 36, 36, 36, 18, 18, 37, 37, 37, 36, 65, 43, 43, 46, 46, 43, 39, 50, 46, 18, 32, 43, 36, 53, 46, 50, 43, 50, 46, 43, 40, 46, 43, 64, 41, 42, 39, 18, 18, 18, 27, 36, 21, 36, 36, 32, 36, 36, 18, 36, 36, 14, 15, 33, 14, 55, 36, 36, 36, 36, 21, 32, 18, 36, 33, 47, 31, 31, 31, 21, 17, 21, 37, 48, 36, 48, 14, 36, 21, 64, 36, 36, 21, 64, 43, 21, 64, 48, 39, 48, 48, 14, 14, 21, 21, 22, 36, 64, 20, 64, 32, 21, 60, 48, 31, 43, 18, 20, 36, 36, 36, 36, 17, 36, 21, 47, 24, 36, 37, 21, 47, 35, 26, 35, 21, 21, 21, 37, 34, 21, 21, 21, 23, 36, 53, 53, 53, 39, 43, 43, 43, 43, 43, 43, 64, 46, 43, 43, 43, 43, 18, 18, 18, 18, 46, 46, 50, 50, 50, 50, 50, 37, 50, 46, 46, 46, 46, 43, 43, 39, 36, 36, 36, 36, 36, 36, 57, 32, 36, 36, 36, 36, 18, 18, 18, 18, 36, 36, 36, 36, 36, 36, 36, 35, 39, 36, 36, 36, 36, 32, 36, 32}) ;
      }

      protected void add_metrics2( )
      {
         getPrinter().setMetrics("Microsoft YaHei UI", true, false, 57, 15, 72, 163,  new int[] {47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 47, 17, 19, 29, 34, 34, 55, 45, 15, 21, 21, 24, 36, 17, 21, 17, 17, 34, 34, 34, 34, 34, 34, 34, 34, 34, 34, 21, 21, 36, 36, 36, 38, 60, 43, 45, 45, 45, 41, 38, 48, 45, 17, 34, 45, 38, 53, 45, 48, 41, 48, 45, 41, 38, 45, 41, 57, 41, 41, 38, 21, 17, 21, 36, 34, 21, 34, 38, 34, 38, 34, 21, 38, 38, 17, 17, 34, 17, 55, 38, 38, 38, 38, 24, 34, 21, 38, 33, 49, 34, 34, 31, 24, 17, 24, 36, 47, 34, 47, 17, 34, 31, 62, 34, 34, 21, 64, 41, 21, 62, 47, 38, 47, 47, 17, 17, 31, 31, 22, 34, 62, 20, 62, 34, 21, 59, 47, 31, 41, 17, 21, 34, 34, 34, 34, 17, 34, 21, 46, 23, 34, 36, 21, 46, 34, 25, 34, 21, 21, 21, 36, 34, 21, 20, 21, 23, 34, 52, 52, 52, 38, 45, 45, 45, 45, 45, 45, 62, 45, 41, 41, 41, 41, 17, 17, 17, 17, 45, 45, 48, 48, 48, 48, 48, 36, 48, 45, 45, 45, 45, 41, 41, 38, 34, 34, 34, 34, 34, 34, 55, 34, 34, 34, 34, 34, 17, 17, 17, 17, 38, 38, 38, 38, 38, 38, 38, 34, 38, 38, 38, 38, 38, 34, 38, 34}) ;
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
         P000H2_A19MedicoCodigo = new String[] {""} ;
         P000H2_n19MedicoCodigo = new bool[] {false} ;
         P000H2_A67PacienteId = new int[1] ;
         P000H2_A41ClinicaCodigo = new String[] {""} ;
         P000H2_A91ConsultaId = new int[1] ;
         P000H2_A159ConsultaEstado = new short[1] ;
         P000H2_A71PacienteApellido2 = new String[] {""} ;
         P000H2_A70PacienteApellido1 = new String[] {""} ;
         P000H2_A69PacienteNombre2 = new String[] {""} ;
         P000H2_A68PacienteNombre1 = new String[] {""} ;
         P000H2_A21MedicoColegiado = new String[] {""} ;
         P000H2_A93ConsultaHora = new String[] {""} ;
         P000H2_A20MedicoNombre = new String[] {""} ;
         P000H2_A92ConsultaFecha = new DateTime[] {DateTime.MinValue} ;
         P000H2_A53ClinicaLogo = new String[] {""} ;
         A19MedicoCodigo = "" ;
         A71PacienteApellido2 = "" ;
         A70PacienteApellido1 = "" ;
         A69PacienteNombre2 = "" ;
         A68PacienteNombre1 = "" ;
         A21MedicoColegiado = "" ;
         A93ConsultaHora = "" ;
         A20MedicoNombre = "" ;
         A92ConsultaFecha = DateTime.MinValue ;
         A53ClinicaLogo = "" ;
         AV8Paciente = "" ;
         P000H3_A41ClinicaCodigo = new String[] {""} ;
         P000H3_A91ConsultaId = new int[1] ;
         P000H3_A109RecetaId = new int[1] ;
         P000H3_A112RecetaObs = new String[] {""} ;
         A112RecetaObs = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.arrecetamedica__default(),
            new Object[][] {
                new Object[] {
               P000H2_A19MedicoCodigo, P000H2_n19MedicoCodigo, P000H2_A67PacienteId, P000H2_A41ClinicaCodigo, P000H2_A91ConsultaId, P000H2_A159ConsultaEstado, P000H2_A71PacienteApellido2, P000H2_A70PacienteApellido1, P000H2_A69PacienteNombre2, P000H2_A68PacienteNombre1,
               P000H2_A21MedicoColegiado, P000H2_A93ConsultaHora, P000H2_A20MedicoNombre, P000H2_A92ConsultaFecha, P000H2_A53ClinicaLogo
               }
               , new Object[] {
               P000H3_A41ClinicaCodigo, P000H3_A91ConsultaId, P000H3_A109RecetaId, P000H3_A112RecetaObs
               }
            }
         );
         /* GeneXus formulas. */
         Gx_line = 0 ;
         context.Gx_err = 0 ;
      }

      private short GxWebError ;
      private short nGotPars ;
      private short A159ConsultaEstado ;
      private int A91ConsultaId ;
      private int M_top ;
      private int M_bot ;
      private int Line ;
      private int ToSkip ;
      private int PrtOffset ;
      private int A67PacienteId ;
      private int Gx_OldLine ;
      private int A109RecetaId ;
      private String GXKey ;
      private String GXDecQS ;
      private String gxfirstwebparm ;
      private String scmdbuf ;
      private String A93ConsultaHora ;
      private DateTime A92ConsultaFecha ;
      private bool entryPointCalled ;
      private bool n19MedicoCodigo ;
      private String A41ClinicaCodigo ;
      private String A19MedicoCodigo ;
      private String A71PacienteApellido2 ;
      private String A70PacienteApellido1 ;
      private String A69PacienteNombre2 ;
      private String A68PacienteNombre1 ;
      private String A21MedicoColegiado ;
      private String A20MedicoNombre ;
      private String AV8Paciente ;
      private String A112RecetaObs ;
      private String A53ClinicaLogo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_ConsultaId ;
      private IDataStoreProvider pr_default ;
      private String[] P000H2_A19MedicoCodigo ;
      private bool[] P000H2_n19MedicoCodigo ;
      private int[] P000H2_A67PacienteId ;
      private String[] P000H2_A41ClinicaCodigo ;
      private int[] P000H2_A91ConsultaId ;
      private short[] P000H2_A159ConsultaEstado ;
      private String[] P000H2_A71PacienteApellido2 ;
      private String[] P000H2_A70PacienteApellido1 ;
      private String[] P000H2_A69PacienteNombre2 ;
      private String[] P000H2_A68PacienteNombre1 ;
      private String[] P000H2_A21MedicoColegiado ;
      private String[] P000H2_A93ConsultaHora ;
      private String[] P000H2_A20MedicoNombre ;
      private DateTime[] P000H2_A92ConsultaFecha ;
      private String[] P000H2_A53ClinicaLogo ;
      private String[] P000H3_A41ClinicaCodigo ;
      private int[] P000H3_A91ConsultaId ;
      private int[] P000H3_A109RecetaId ;
      private String[] P000H3_A112RecetaObs ;
   }

   public class arrecetamedica__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000H2 ;
          prmP000H2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmP000H3 ;
          prmP000H3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ConsultaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000H2", "SELECT T1.[MedicoCodigo], T1.[PacienteId], T1.[ClinicaCodigo], T1.[ConsultaId], T1.[ConsultaEstado], T4.[PacienteApellido2], T4.[PacienteApellido1], T4.[PacienteNombre2], T4.[PacienteNombre1], T3.[MedicoColegiado], T1.[ConsultaHora], T3.[MedicoNombre], T1.[ConsultaFecha], T2.[ClinicaLogo] FROM ((([Consulta] T1 WITH (NOLOCK) INNER JOIN [Clinica] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo]) LEFT JOIN [Medico] T3 WITH (NOLOCK) ON T3.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T3.[MedicoCodigo] = T1.[MedicoCodigo]) INNER JOIN [Paciente] T4 WITH (NOLOCK) ON T4.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T4.[PacienteId] = T1.[PacienteId]) WHERE T1.[ClinicaCodigo] = @ClinicaCodigo and T1.[ConsultaId] = @ConsultaId ORDER BY T1.[ClinicaCodigo], T1.[ConsultaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H2,1,0,false,true )
             ,new CursorDef("P000H3", "SELECT [ClinicaCodigo], [ConsultaId], [RecetaId], [RecetaObs] FROM [Receta] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ConsultaId] = @ConsultaId ORDER BY [ClinicaCodigo], [ConsultaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000H3,100,0,false,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((int[]) buf[2])[0] = rslt.getInt(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[4])[0] = rslt.getInt(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(9) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((String[]) buf[11])[0] = rslt.getString(11, 8) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(12) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(13) ;
                ((String[]) buf[14])[0] = rslt.getBLOBFile(14, "JPG", "") ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
