/*
               File: wp_depositobancario
        Description: Depósitos Bancarios
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:3.5
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class wp_depositobancario : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_depositobancario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_depositobancario( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            gxfirstwebparm_bkp = gxfirstwebparm ;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( ) ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_24_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_24_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_24_idx, sGXsfl_24_idx) ;
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp ;
            }
         }
         context.SetTheme("Fantastic");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA312( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START312( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?58720");
            context.AddJavascriptSource("gxfxSD.js", "?58720");
            context.AddJavascriptSource("gxtypesSD.js", "?58720");
            context.AddJavascriptSource("gxpopupSD.js", "?58720");
            context.AddJavascriptSource("gxfrmutlSD.js", "?58720");
            context.AddJavascriptSource("gxgridSD.js", "?58720");
            context.AddJavascriptSource("JavaScripTableSD.js", "?58720");
            context.AddJavascriptSource("rijndaelSD.js", "?58720");
            context.AddJavascriptSource("gxgralSD.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         context.AddJavascriptSource("calendar.js", "?58720");
         context.AddJavascriptSource("calendar-setup.js", "?58720");
         context.AddJavascriptSource("calendar-es.js", "?58720");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_depositobancario.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE312( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT312( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_depositobancario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Depósitos Bancarios" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_depositobancario.aspx")  ;
      }

      protected void WB310( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_312( true) ;
         }
         else
         {
            wb_table1_2_312( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_312e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START312( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Depósitos Bancarios", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP310( ) ;
      }

      protected void WS312( )
      {
         START312( ) ;
         EVT312( ) ;
      }

      protected void EVT312( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11312 */
                              E11312 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NUEVO DEPóSITO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12312 */
                              E12312 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_24_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
                              edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_24_idx ;
                              edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_24_idx ;
                              edtDepositoId_Internalname = "DEPOSITOID_"+sGXsfl_24_idx ;
                              edtDepositoFecha_Internalname = "DEPOSITOFECHA_"+sGXsfl_24_idx ;
                              edtDepositoEfectivo_Internalname = "DEPOSITOEFECTIVO_"+sGXsfl_24_idx ;
                              edtDepositoCheque_Internalname = "DEPOSITOCHEQUE_"+sGXsfl_24_idx ;
                              edtDepositoTotal_Internalname = "DEPOSITOTOTAL_"+sGXsfl_24_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A126BancoCodigo = cgiGet( edtBancoCodigo_Internalname) ;
                              A127BancoDescripcion = cgiGet( edtBancoDescripcion_Internalname) ;
                              A282DepositoId = (int)(context.localUtil.CToN( cgiGet( edtDepositoId_Internalname), ".", ",")) ;
                              A283DepositoFecha = context.localUtil.CToD( cgiGet( edtDepositoFecha_Internalname), 2) ;
                              A284DepositoEfectivo = context.localUtil.CToN( cgiGet( edtDepositoEfectivo_Internalname), ".", ",") ;
                              A285DepositoCheque = context.localUtil.CToN( cgiGet( edtDepositoCheque_Internalname), ".", ",") ;
                              A286DepositoTotal = context.localUtil.CToN( cgiGet( edtDepositoTotal_Internalname), ".", ",") ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E13312 */
                                    E13312 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E14312 */
                                    E14312 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE312( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA312( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GX_FocusControl = edtavDepositofechad_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_24_idx ,
                                       String sGXsfl_24_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
         edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_24_idx ;
         edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_24_idx ;
         edtDepositoId_Internalname = "DEPOSITOID_"+sGXsfl_24_idx ;
         edtDepositoFecha_Internalname = "DEPOSITOFECHA_"+sGXsfl_24_idx ;
         edtDepositoEfectivo_Internalname = "DEPOSITOEFECTIVO_"+sGXsfl_24_idx ;
         edtDepositoCheque_Internalname = "DEPOSITOCHEQUE_"+sGXsfl_24_idx ;
         edtDepositoTotal_Internalname = "DEPOSITOTOTAL_"+sGXsfl_24_idx ;
         while ( nGXsfl_24_idx <= nRC_Grid1 )
         {
            sendrow_242( ) ;
            nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
            edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_24_idx ;
            edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_24_idx ;
            edtDepositoId_Internalname = "DEPOSITOID_"+sGXsfl_24_idx ;
            edtDepositoFecha_Internalname = "DEPOSITOFECHA_"+sGXsfl_24_idx ;
            edtDepositoEfectivo_Internalname = "DEPOSITOEFECTIVO_"+sGXsfl_24_idx ;
            edtDepositoCheque_Internalname = "DEPOSITOCHEQUE_"+sGXsfl_24_idx ;
            edtDepositoTotal_Internalname = "DEPOSITOTOTAL_"+sGXsfl_24_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void Refresh( )
      {
         RF312( ) ;
         /* End function Refresh */
      }

      protected void RF312( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 24 ;
         nGXsfl_24_idx = 1 ;
         sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
         edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_24_idx ;
         edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_24_idx ;
         edtDepositoId_Internalname = "DEPOSITOID_"+sGXsfl_24_idx ;
         edtDepositoFecha_Internalname = "DEPOSITOFECHA_"+sGXsfl_24_idx ;
         edtDepositoEfectivo_Internalname = "DEPOSITOEFECTIVO_"+sGXsfl_24_idx ;
         edtDepositoCheque_Internalname = "DEPOSITOCHEQUE_"+sGXsfl_24_idx ;
         edtDepositoTotal_Internalname = "DEPOSITOTOTAL_"+sGXsfl_24_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
            edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_24_idx ;
            edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_24_idx ;
            edtDepositoId_Internalname = "DEPOSITOID_"+sGXsfl_24_idx ;
            edtDepositoFecha_Internalname = "DEPOSITOFECHA_"+sGXsfl_24_idx ;
            edtDepositoEfectivo_Internalname = "DEPOSITOEFECTIVO_"+sGXsfl_24_idx ;
            edtDepositoCheque_Internalname = "DEPOSITOCHEQUE_"+sGXsfl_24_idx ;
            edtDepositoTotal_Internalname = "DEPOSITOTOTAL_"+sGXsfl_24_idx ;
            /* Using cursor H00312 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A128CuentaBancariaCodigo = H00312_A128CuentaBancariaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A128CuentaBancariaCodigo", A128CuentaBancariaCodigo);
               A283DepositoFecha = H00312_A283DepositoFecha[0] ;
               A282DepositoId = H00312_A282DepositoId[0] ;
               A127BancoDescripcion = H00312_A127BancoDescripcion[0] ;
               A126BancoCodigo = H00312_A126BancoCodigo[0] ;
               A41ClinicaCodigo = H00312_A41ClinicaCodigo[0] ;
               A285DepositoCheque = H00312_A285DepositoCheque[0] ;
               A284DepositoEfectivo = H00312_A284DepositoEfectivo[0] ;
               A126BancoCodigo = H00312_A126BancoCodigo[0] ;
               A127BancoDescripcion = H00312_A127BancoDescripcion[0] ;
               A286DepositoTotal = (decimal)(A284DepositoEfectivo+A285DepositoCheque) ;
               /* Execute user event: E14312 */
               E14312 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 24 ;
            WB310( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP310( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E13312 */
         E13312 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( context.localUtil.VCDate( cgiGet( edtavDepositofechad_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Deposito Fecha D"}), 1, "vDEPOSITOFECHAD");
               GX_FocusControl = edtavDepositofechad_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7DepositoFechaD = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7DepositoFechaD", context.localUtil.Format(AV7DepositoFechaD, "99/99/99"));
            }
            else
            {
               AV7DepositoFechaD = context.localUtil.CToD( cgiGet( edtavDepositofechad_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7DepositoFechaD", context.localUtil.Format(AV7DepositoFechaD, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDepositofechaa_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Deposito Fecha A"}), 1, "vDEPOSITOFECHAA");
               GX_FocusControl = edtavDepositofechaa_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8DepositoFechaA = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8DepositoFechaA", context.localUtil.Format(AV8DepositoFechaA, "99/99/99"));
            }
            else
            {
               AV8DepositoFechaA = context.localUtil.CToD( cgiGet( edtavDepositofechaa_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8DepositoFechaA", context.localUtil.Format(AV8DepositoFechaA, "99/99/99"));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E13312 */
         E13312 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13312( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV5Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV5Parametros = GXt_SdtParametros4 ;
         AV6ClinicaCodigo = AV5Parametros.gxTpr_Pclinicacodigo ;
         AV7DepositoFechaD = context.localUtil.YMDToD( DateTimeUtil.Year( Gx_date), DateTimeUtil.Month( Gx_date), 1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7DepositoFechaD", context.localUtil.Format(AV7DepositoFechaD, "99/99/99"));
         AV8DepositoFechaA = DateTimeUtil.DateEndOfMonth( AV7DepositoFechaD) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8DepositoFechaA", context.localUtil.Format(AV8DepositoFechaA, "99/99/99"));
      }

      protected void E11312( )
      {
         /* 'Regresar' Routine */
         context.wjLoc = formatLink("principal.aspx")  ;
      }

      protected void E12312( )
      {
         /* 'Nuevo Depósito' Routine */
         context.wjLoc = formatLink("depositobancario.aspx")  ;
      }

      private void E14312( )
      {
         /* Load Routine */
         sendrow_242( ) ;
      }

      protected void wb_table1_2_312( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:16.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Depósitos Bancarios", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_depositobancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_11_312( true) ;
         }
         else
         {
            wb_table2_11_312( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_312e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"24\">") ;
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Banco") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Depósito") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Efectivo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Cheques") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Total") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Titlefont", StringUtil.RTrim( subGrid1_Titlefont));
               Grid1Container.AddObjectProperty("Linesfont", StringUtil.RTrim( subGrid1_Linesfont));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A126BancoCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A127BancoDescripcion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A282DepositoId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A283DepositoFecha, "99/99/99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A284DepositoEfectivo, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A285DepositoCheque, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A286DepositoTotal, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 24 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_24_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "Nuevo Depósito", bttButton1_Jsonclick, 5, "Nuevo Depósito", "", StyleString, ClassString, 1, 1, "standard", "E\\'NUEVO DEPóSITO\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_depositobancario.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "Regresar", bttButton2_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_depositobancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_312e( true) ;
         }
         else
         {
            wb_table1_2_312e( false) ;
         }
      }

      protected void wb_table2_11_312( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Fecha Del", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_depositobancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Fecha Al", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_depositobancario.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7DepositoFechaD", context.localUtil.Format(AV7DepositoFechaD, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavDepositofechad_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDepositofechad_Internalname, context.localUtil.Format(AV7DepositoFechaD, "99/99/99"), context.localUtil.Format( AV7DepositoFechaD, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(19);\"", "", "", "", "", edtavDepositofechad_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_depositobancario.htm");
            GxWebStd.gx_bitmap( context, edtavDepositofechad_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_depositobancario.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8DepositoFechaA", context.localUtil.Format(AV8DepositoFechaA, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavDepositofechaa_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDepositofechaa_Internalname, context.localUtil.Format(AV8DepositoFechaA, "99/99/99"), context.localUtil.Format( AV8DepositoFechaA, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(21);\"", "", "", "", "", edtavDepositofechaa_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_depositobancario.htm");
            GxWebStd.gx_bitmap( context, edtavDepositofechaa_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_depositobancario.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_312e( true) ;
         }
         else
         {
            wb_table2_11_312e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA312( ) ;
         WS312( ) ;
         WE312( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?158348");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("wp_depositobancario.js", "?158348");
         /* End function include_jscripts */
      }

      protected void sendrow_242( )
      {
         WB310( ) ;
         Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
         if ( subGrid1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid1_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd" ;
            }
         }
         else if ( subGrid1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid1_Backstyle = 0 ;
            subGrid1_Backcolor = subGrid1_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
            }
         }
         else if ( subGrid1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd" ;
            }
            subGrid1_Backcolor = (int)(0x0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1 ;
            if ( ((int)(nGXsfl_24_idx) % (2)) == 0 )
            {
               subGrid1_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even" ;
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
         }
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( " gxrow=\""+sGXsfl_24_idx+"\">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBancoCodigo_Internalname,StringUtil.RTrim( A126BancoCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtBancoCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBancoDescripcion_Internalname,StringUtil.RTrim( A127BancoDescripcion),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtBancoDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDepositoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A282DepositoId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A282DepositoId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtDepositoId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDepositoFecha_Internalname,context.localUtil.Format(A283DepositoFecha, "99/99/99"),context.localUtil.Format( A283DepositoFecha, "99/99/99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtDepositoFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDepositoEfectivo_Internalname,StringUtil.LTrim( StringUtil.NToC( A284DepositoEfectivo, 17, 2, ".", "")),context.localUtil.Format( A284DepositoEfectivo, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtDepositoEfectivo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDepositoCheque_Internalname,StringUtil.LTrim( StringUtil.NToC( A285DepositoCheque, 17, 2, ".", "")),context.localUtil.Format( A285DepositoCheque, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtDepositoCheque_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDepositoTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A286DepositoTotal, 17, 2, ".", "")),context.localUtil.Format( A286DepositoTotal, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtDepositoTotal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"right"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
         sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
         edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_24_idx ;
         edtBancoDescripcion_Internalname = "BANCODESCRIPCION_"+sGXsfl_24_idx ;
         edtDepositoId_Internalname = "DEPOSITOID_"+sGXsfl_24_idx ;
         edtDepositoFecha_Internalname = "DEPOSITOFECHA_"+sGXsfl_24_idx ;
         edtDepositoEfectivo_Internalname = "DEPOSITOEFECTIVO_"+sGXsfl_24_idx ;
         edtDepositoCheque_Internalname = "DEPOSITOCHEQUE_"+sGXsfl_24_idx ;
         edtDepositoTotal_Internalname = "DEPOSITOTOTAL_"+sGXsfl_24_idx ;
         /* End function sendrow_242 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtavDepositofechad_Internalname = "vDEPOSITOFECHAD" ;
         edtavDepositofechaa_Internalname = "vDEPOSITOFECHAA" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtDepositoTotal_Jsonclick = "" ;
         edtDepositoCheque_Jsonclick = "" ;
         edtDepositoEfectivo_Jsonclick = "" ;
         edtDepositoFecha_Jsonclick = "" ;
         edtDepositoId_Jsonclick = "" ;
         edtBancoDescripcion_Jsonclick = "" ;
         edtBancoCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavDepositofechaa_Jsonclick = "" ;
         edtavDepositofechad_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Linesfont = "font-family:Microsoft YaHei UI;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Microsoft YaHei UI;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Depósitos Bancarios" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtBancoCodigo_Internalname = "" ;
         edtBancoDescripcion_Internalname = "" ;
         edtDepositoId_Internalname = "" ;
         edtDepositoFecha_Internalname = "" ;
         edtDepositoEfectivo_Internalname = "" ;
         edtDepositoCheque_Internalname = "" ;
         edtDepositoTotal_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A126BancoCodigo = "" ;
         A127BancoDescripcion = "" ;
         A283DepositoFecha = DateTime.MinValue ;
         GXKey = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H00312_A128CuentaBancariaCodigo = new String[] {""} ;
         H00312_A283DepositoFecha = new DateTime[] {DateTime.MinValue} ;
         H00312_A282DepositoId = new int[1] ;
         H00312_A127BancoDescripcion = new String[] {""} ;
         H00312_A126BancoCodigo = new String[] {""} ;
         H00312_A41ClinicaCodigo = new String[] {""} ;
         H00312_A285DepositoCheque = new decimal[1] ;
         H00312_A284DepositoEfectivo = new decimal[1] ;
         A128CuentaBancariaCodigo = "" ;
         Gx_date = DateTime.MinValue ;
         AV7DepositoFechaD = DateTime.MinValue ;
         AV8DepositoFechaA = DateTime.MinValue ;
         AV5Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         AV6ClinicaCodigo = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         GXt_char8 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char9 = "" ;
         ROClassString = "" ;
         GXt_char10 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_depositobancario__default(),
            new Object[][] {
                new Object[] {
               H00312_A128CuentaBancariaCodigo, H00312_A283DepositoFecha, H00312_A282DepositoId, H00312_A127BancoDescripcion, H00312_A126BancoCodigo, H00312_A41ClinicaCodigo, H00312_A285DepositoCheque, H00312_A284DepositoEfectivo
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_24_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int A282DepositoId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal A284DepositoEfectivo ;
      private decimal A285DepositoCheque ;
      private decimal A286DepositoTotal ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_24_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtClinicaCodigo_Internalname ;
      private String edtBancoCodigo_Internalname ;
      private String edtBancoDescripcion_Internalname ;
      private String edtDepositoId_Internalname ;
      private String edtDepositoFecha_Internalname ;
      private String edtDepositoEfectivo_Internalname ;
      private String edtDepositoCheque_Internalname ;
      private String edtDepositoTotal_Internalname ;
      private String GXKey ;
      private String edtavDepositofechad_Internalname ;
      private String scmdbuf ;
      private String edtavDepositofechaa_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtavDepositofechad_Jsonclick ;
      private String edtavDepositofechaa_Jsonclick ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtBancoCodigo_Jsonclick ;
      private String edtBancoDescripcion_Jsonclick ;
      private String edtDepositoId_Jsonclick ;
      private String edtDepositoFecha_Jsonclick ;
      private String edtDepositoEfectivo_Jsonclick ;
      private String edtDepositoCheque_Jsonclick ;
      private String edtDepositoTotal_Jsonclick ;
      private String GXt_char10 ;
      private DateTime A283DepositoFecha ;
      private DateTime Gx_date ;
      private DateTime AV7DepositoFechaD ;
      private DateTime AV8DepositoFechaA ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String A41ClinicaCodigo ;
      private String A126BancoCodigo ;
      private String A127BancoDescripcion ;
      private String A128CuentaBancariaCodigo ;
      private String AV6ClinicaCodigo ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H00312_A128CuentaBancariaCodigo ;
      private DateTime[] H00312_A283DepositoFecha ;
      private int[] H00312_A282DepositoId ;
      private String[] H00312_A127BancoDescripcion ;
      private String[] H00312_A126BancoCodigo ;
      private String[] H00312_A41ClinicaCodigo ;
      private decimal[] H00312_A285DepositoCheque ;
      private decimal[] H00312_A284DepositoEfectivo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV5Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class wp_depositobancario__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00312 ;
          prmH00312 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H00312", "SELECT T1.[CuentaBancariaCodigo], T1.[DepositoFecha], T1.[DepositoId], T3.[BancoDescripcion], T2.[BancoCodigo], T1.[ClinicaCodigo], T1.[DepositoCheque], T1.[DepositoEfectivo] FROM (([DepositoBancario] T1 WITH (NOLOCK) INNER JOIN [CuentaBancaria] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[CuentaBancariaCodigo] = T1.[CuentaBancariaCodigo]) LEFT JOIN [Banco] T3 WITH (NOLOCK) ON T3.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T3.[BancoCodigo] = T2.[BancoCodigo]) ORDER BY T1.[ClinicaCodigo], T1.[CuentaBancariaCodigo], T1.[DepositoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00312,11,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
