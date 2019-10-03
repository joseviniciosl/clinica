/*
               File: wp_cortecaja
        Description: Cortes de caja
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:0.33
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
   public class wp_cortecaja : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_cortecaja( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_cortecaja( IGxContext context )
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
         dynavCajacodigo = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vCAJACODIGO") == 0 )
            {
               AV6ClinicaCodigo = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLVvCAJACODIGO2Y2( AV6ClinicaCodigo) ;
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
               nGXsfl_28_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_28_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_28_idx, sGXsfl_28_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               Gx_date = DateTimeUtil.Today( ) ;
               context.Gx_err = 0 ;
               dynavCajacodigo.Name = "vCAJACODIGO" ;
               dynavCajacodigo.WebTags = "" ;
               Grid1_PageSize28 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize28) ;
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
         PA2Y2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2Y2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_cortecaja.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV6ClinicaCodigo));
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
            WE2Y2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2Y2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_cortecaja" ;
      }

      public override String GetPgmdesc( )
      {
         return "Cortes de caja" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_cortecaja.aspx")  ;
      }

      protected void WB2Y0( )
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
            wb_table1_2_2Y2( true) ;
         }
         else
         {
            wb_table1_2_2Y2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2Y2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2Y2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Cortes de caja", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2Y0( ) ;
      }

      protected void WS2Y2( )
      {
         START2Y2( ) ;
         EVT2Y2( ) ;
      }

      protected void EVT2Y2( )
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
                  /* Check if conditions changed and reset current page numbers */
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
                           else if ( StringUtil.StrCmp(sEvt, "'FIRST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E112Y2 */
                              E112Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E122Y2 */
                              E122Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E132Y2 */
                              E132Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E142Y2 */
                              E142Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E152Y2 */
                              E152Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REPORTES DE CORTE'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E162Y2 */
                              E162Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'RECALCULAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E172Y2 */
                              E172Y2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NUEVO CORTE'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E182Y2 */
                              E182Y2 ();
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
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_28_idx ;
                              edtCajaCodigo_Internalname = "CAJACODIGO_"+sGXsfl_28_idx ;
                              edtCorteCajaId_Internalname = "CORTECAJAID_"+sGXsfl_28_idx ;
                              edtCorteCajaFechaD_Internalname = "CORTECAJAFECHAD_"+sGXsfl_28_idx ;
                              edtCorteCajaFechaA_Internalname = "CORTECAJAFECHAA_"+sGXsfl_28_idx ;
                              edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_28_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A132CajaCodigo = cgiGet( edtCajaCodigo_Internalname) ;
                              A153CorteCajaId = (int)(context.localUtil.CToN( cgiGet( edtCorteCajaId_Internalname), ".", ",")) ;
                              A278CorteCajaFechaD = context.localUtil.CToT( cgiGet( edtCorteCajaFechaD_Internalname)) ;
                              A279CorteCajaFechaA = context.localUtil.CToT( cgiGet( edtCorteCajaFechaA_Internalname)) ;
                              A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E192Y2 */
                                    E192Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E202Y2 */
                                    E202Y2 ();
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

      protected void WE2Y2( )
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

      protected void PA2Y2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            dynavCajacodigo.Name = "vCAJACODIGO" ;
            dynavCajacodigo.WebTags = "" ;
            GX_FocusControl = dynavCajacodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvCAJACODIGO2Y2( String AV6ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvCAJACODIGO_data2Y2( AV6ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXVvCAJACODIGO_html2Y2( String AV6ClinicaCodigo )
      {
         String gxdynajaxvalue ;
         GXDLVvCAJACODIGO_data2Y2( AV6ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynavCajacodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynavCajacodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavCajacodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV9CajaCodigo)) )
            {
               AV9CajaCodigo = dynavCajacodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9CajaCodigo", AV9CajaCodigo);
            }
         }
      }

      protected void GXDLVvCAJACODIGO_data2Y2( String AV6ClinicaCodigo )
      {
         /* Using cursor H002Y2 */
         pr_default.execute(0, new Object[] {AV6ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H002Y2_A132CajaCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H002Y2_A133CajaDescripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_28_idx ,
                                       String sGXsfl_28_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_28_idx ;
         edtCajaCodigo_Internalname = "CAJACODIGO_"+sGXsfl_28_idx ;
         edtCorteCajaId_Internalname = "CORTECAJAID_"+sGXsfl_28_idx ;
         edtCorteCajaFechaD_Internalname = "CORTECAJAFECHAD_"+sGXsfl_28_idx ;
         edtCorteCajaFechaA_Internalname = "CORTECAJAFECHAA_"+sGXsfl_28_idx ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_28_idx ;
         while ( nGXsfl_28_idx <= nRC_Grid1 )
         {
            sendrow_282( ) ;
            nGXsfl_28_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1)) ;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_28_idx ;
            edtCajaCodigo_Internalname = "CAJACODIGO_"+sGXsfl_28_idx ;
            edtCorteCajaId_Internalname = "CORTECAJAID_"+sGXsfl_28_idx ;
            edtCorteCajaFechaD_Internalname = "CORTECAJAFECHAD_"+sGXsfl_28_idx ;
            edtCorteCajaFechaA_Internalname = "CORTECAJAFECHAA_"+sGXsfl_28_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_28_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize28 )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize28) ;
         RF2Y2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2Y2( ) ;
         /* End function Refresh */
      }

      protected void RF2Y2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 28 ;
         nGXsfl_28_idx = 1 ;
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_28_idx ;
         edtCajaCodigo_Internalname = "CAJACODIGO_"+sGXsfl_28_idx ;
         edtCorteCajaId_Internalname = "CORTECAJAID_"+sGXsfl_28_idx ;
         edtCorteCajaFechaD_Internalname = "CORTECAJAFECHAD_"+sGXsfl_28_idx ;
         edtCorteCajaFechaA_Internalname = "CORTECAJAFECHAA_"+sGXsfl_28_idx ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_28_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_28_idx ;
            edtCajaCodigo_Internalname = "CAJACODIGO_"+sGXsfl_28_idx ;
            edtCorteCajaId_Internalname = "CORTECAJAID_"+sGXsfl_28_idx ;
            edtCorteCajaFechaD_Internalname = "CORTECAJAFECHAD_"+sGXsfl_28_idx ;
            edtCorteCajaFechaA_Internalname = "CORTECAJAFECHAA_"+sGXsfl_28_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_28_idx ;
            /* Using cursor H002Y3 */
            pr_default.execute(1);
            nGXsfl_28_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(1) != 101) ) && ( ( ( 12 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A4UsuarioCodigo = H002Y3_A4UsuarioCodigo[0] ;
               A279CorteCajaFechaA = H002Y3_A279CorteCajaFechaA[0] ;
               A278CorteCajaFechaD = H002Y3_A278CorteCajaFechaD[0] ;
               A153CorteCajaId = H002Y3_A153CorteCajaId[0] ;
               A132CajaCodigo = H002Y3_A132CajaCodigo[0] ;
               A41ClinicaCodigo = H002Y3_A41ClinicaCodigo[0] ;
               /* Execute user event: E202Y2 */
               E202Y2 ();
               pr_default.readNext(1);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(1) == 101) ? 1 : 0)) ;
            pr_default.close(1);
            wbEnd = 28 ;
            WB2Y0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         /* Using cursor H002Y4 */
         pr_default.execute(2);
         GRID1_nRecordCount = H002Y4_AGRID1_nRecordCount[0] ;
         pr_default.close(2);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 12 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(12*1) ;
            }
            else
            {
               return (int)(12) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP2Y0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E192Y2 */
         E192Y2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         GXVvCAJACODIGO_html2Y2( AV6ClinicaCodigo) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            dynavCajacodigo.Name = dynavCajacodigo_Internalname ;
            dynavCajacodigo.CurrentValue = cgiGet( dynavCajacodigo_Internalname) ;
            AV9CajaCodigo = cgiGet( dynavCajacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9CajaCodigo", AV9CajaCodigo);
            if ( context.localUtil.VCDate( cgiGet( edtavCortecajafechadel_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Corte Caja Fecha Del"}), 1, "vCORTECAJAFECHADEL");
               GX_FocusControl = edtavCortecajafechadel_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7CorteCajaFechaDel = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CorteCajaFechaDel", context.localUtil.Format(AV7CorteCajaFechaDel, "99/99/99"));
            }
            else
            {
               AV7CorteCajaFechaDel = context.localUtil.CToD( cgiGet( edtavCortecajafechadel_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CorteCajaFechaDel", context.localUtil.Format(AV7CorteCajaFechaDel, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCortecajafechaal_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Corte Caja Fecha Al"}), 1, "vCORTECAJAFECHAAL");
               GX_FocusControl = edtavCortecajafechaal_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8CorteCajaFechaAl = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8CorteCajaFechaAl", context.localUtil.Format(AV8CorteCajaFechaAl, "99/99/99"));
            }
            else
            {
               AV8CorteCajaFechaAl = context.localUtil.CToD( cgiGet( edtavCortecajafechaal_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8CorteCajaFechaAl", context.localUtil.Format(AV8CorteCajaFechaAl, "99/99/99"));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ",")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ",")) ;
            /* Read subfile selected row values. */
            nGXsfl_28_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ".", ",")) ;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_28_idx ;
            edtCajaCodigo_Internalname = "CAJACODIGO_"+sGXsfl_28_idx ;
            edtCorteCajaId_Internalname = "CORTECAJAID_"+sGXsfl_28_idx ;
            edtCorteCajaFechaD_Internalname = "CORTECAJAFECHAD_"+sGXsfl_28_idx ;
            edtCorteCajaFechaA_Internalname = "CORTECAJAFECHAA_"+sGXsfl_28_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_28_idx ;
            if ( nGXsfl_28_idx > 0 )
            {
               A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
               A132CajaCodigo = cgiGet( edtCajaCodigo_Internalname) ;
               A153CorteCajaId = (int)(context.localUtil.CToN( cgiGet( edtCorteCajaId_Internalname), ".", ",")) ;
               A278CorteCajaFechaD = context.localUtil.CToT( cgiGet( edtCorteCajaFechaD_Internalname)) ;
               A279CorteCajaFechaA = context.localUtil.CToT( cgiGet( edtCorteCajaFechaA_Internalname)) ;
               A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E192Y2 */
         E192Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E192Y2( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV5Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV5Parametros = GXt_SdtParametros4 ;
         AV6ClinicaCodigo = AV5Parametros.gxTpr_Pclinicacodigo ;
         AV10UsuarioCodigo = AV5Parametros.gxTpr_Pusuariocodigo ;
         AV7CorteCajaFechaDel = context.localUtil.YMDToD( DateTimeUtil.Year( Gx_date), DateTimeUtil.Month( Gx_date), 1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CorteCajaFechaDel", context.localUtil.Format(AV7CorteCajaFechaDel, "99/99/99"));
         AV8CorteCajaFechaAl = DateTimeUtil.DateEndOfMonth( AV7CorteCajaFechaDel) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8CorteCajaFechaAl", context.localUtil.Format(AV8CorteCajaFechaAl, "99/99/99"));
         bttButton6_Jsonclick = "confirm('¿Seguro de recalcular el corte de caja seleccionado?')" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton6_Internalname, "Jsonclick", bttButton6_Jsonclick);
      }

      protected void E112Y2( )
      {
         /* 'First' Routine */
         subgrid1_firstpage( ) ;
      }

      protected void E122Y2( )
      {
         /* 'Previous' Routine */
         subgrid1_previouspage( ) ;
      }

      protected void E132Y2( )
      {
         /* 'Next' Routine */
         subgrid1_nextpage( ) ;
      }

      protected void E142Y2( )
      {
         /* 'Last' Routine */
         subgrid1_lastpage( ) ;
      }

      protected void E152Y2( )
      {
         /* 'Regresar' Routine */
         context.wjLoc = formatLink("principal.aspx")  ;
      }

      protected void E162Y2( )
      {
         /* 'Reportes de Corte' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +A153CorteCajaId) ;
         context.wjLoc = formatLink("wp_reportescortecaja.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E172Y2( )
      {
         /* 'Recalcular' Routine */
         GXt_int5 = 2 ;
         new pcalculacortecaja(context ).execute( ref  AV6ClinicaCodigo, ref  A132CajaCodigo, ref  A153CorteCajaId, ref  A278CorteCajaFechaD, ref  A279CorteCajaFechaA, ref  AV10UsuarioCodigo, ref  GXt_int5) ;
         GX_msglist.addItem("Recalculo de corte de caja generado exitosamente. Genere los reportes.");
      }

      protected void E182Y2( )
      {
         /* 'Nuevo Corte' Routine */
         context.wjLoc = formatLink("wp_generacortecaja.aspx")  ;
      }

      private void E202Y2( )
      {
         /* Load Routine */
         if ( ( subGrid1_Islastpage == 1 ) || ( 12 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_282( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_2_2Y2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:16.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Cortes de Caja", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_cortecaja.htm");
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
            wb_table2_11_2Y2( true) ;
         }
         else
         {
            wb_table2_11_2Y2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_2Y2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"28\">") ;
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
               context.SendWebValue( "Caja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Corte") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Fecha_Del") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Fecha_Al") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Usuario") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A132CajaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A153CorteCajaId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A278CorteCajaFechaD, "99/99/99 99:99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A279CorteCajaFechaA, "99/99/99 99:99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A4UsuarioCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 28 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_28_idx-1) ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 3, 0)+","+"null"+");", "|<", bttButton1_Jsonclick, 5, "|<", "", StyleString, ClassString, 1, 1, "standard", "E\\'FIRST\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 3, 0)+","+"null"+");", "<", bttButton2_Jsonclick, 5, "<", "", StyleString, ClassString, 1, 1, "standard", "E\\'PREVIOUS\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 3, 0)+","+"null"+");", ">", bttButton3_Jsonclick, 5, ">", "", StyleString, ClassString, 1, 1, "standard", "E\\'NEXT\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton4_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 3, 0)+","+"null"+");", ">|", bttButton4_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'LAST\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton5_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 3, 0)+","+"null"+");", "Nuevo Corte", bttButton5_Jsonclick, 5, "Nuevo Corte", "", StyleString, ClassString, 1, 1, "standard", "E\\'NUEVO CORTE\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton6_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 3, 0)+","+"null"+");", "Recalcular", bttButton6_Jsonclick, 5, "Recalcular", "", StyleString, ClassString, 1, 1, "standard", "E\\'RECALCULAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton7_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 3, 0)+","+"null"+");", "Reportes de Corte", bttButton7_Jsonclick, 5, "Reportes de Corte", "", StyleString, ClassString, 1, 1, "standard", "E\\'REPORTES DE CORTE\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton8_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 3, 0)+","+"null"+");", "Regresar", bttButton8_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2Y2e( true) ;
         }
         else
         {
            wb_table1_2_2Y2e( false) ;
         }
      }

      protected void wb_table2_11_2Y2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Caja", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Fecha Del", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Fecha Al", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_cortecaja.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9CajaCodigo", AV9CajaCodigo);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'" + sGXsfl_28_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavCajacodigo, dynavCajacodigo_Internalname, AV9CajaCodigo, 1, dynavCajacodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(21);\"", "", true, "HLP_wp_cortecaja.htm");
            dynavCajacodigo.CurrentValue = AV9CajaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavCajacodigo_Internalname, "Values", (String)(dynavCajacodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7CorteCajaFechaDel", context.localUtil.Format(AV7CorteCajaFechaDel, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_28_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavCortecajafechadel_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCortecajafechadel_Internalname, context.localUtil.Format(AV7CorteCajaFechaDel, "99/99/99"), context.localUtil.Format( AV7CorteCajaFechaDel, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(23);\"", "", "", "", "", edtavCortecajafechadel_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_cortecaja.htm");
            GxWebStd.gx_bitmap( context, edtavCortecajafechadel_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_cortecaja.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8CorteCajaFechaAl", context.localUtil.Format(AV8CorteCajaFechaAl, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'" + sGXsfl_28_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavCortecajafechaal_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCortecajafechaal_Internalname, context.localUtil.Format(AV8CorteCajaFechaAl, "99/99/99"), context.localUtil.Format( AV8CorteCajaFechaAl, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(25);\"", "", "", "", "", edtavCortecajafechaal_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_cortecaja.htm");
            GxWebStd.gx_bitmap( context, edtavCortecajafechaal_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_cortecaja.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_2Y2e( true) ;
         }
         else
         {
            wb_table2_11_2Y2e( false) ;
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
         PA2Y2( ) ;
         WS2Y2( ) ;
         WE2Y2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?158095");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("wp_cortecaja.js", "?158095");
         /* End function include_jscripts */
      }

      protected void sendrow_282( )
      {
         WB2Y0( ) ;
         if ( ( 12 * 1 == 0 ) || ( nGXsfl_28_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
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
               if ( ((int)(nGXsfl_28_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_28_idx+"\">") ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)28,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCajaCodigo_Internalname,StringUtil.RTrim( A132CajaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCajaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)28,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCorteCajaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A153CorteCajaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A153CorteCajaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCorteCajaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)28,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCorteCajaFechaD_Internalname,context.localUtil.Format(A278CorteCajaFechaD, "99/99/99 99:99"),context.localUtil.Format( A278CorteCajaFechaD, "99/99/99 99:99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCorteCajaFechaD_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)28,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCorteCajaFechaA_Internalname,context.localUtil.Format(A279CorteCajaFechaA, "99/99/99 99:99"),context.localUtil.Format( A279CorteCajaFechaA, "99/99/99 99:99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCorteCajaFechaA_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)14,(short)0,(short)0,(short)28,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioCodigo_Internalname,StringUtil.RTrim( A4UsuarioCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)28,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_28_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1)) ;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_28_idx ;
            edtCajaCodigo_Internalname = "CAJACODIGO_"+sGXsfl_28_idx ;
            edtCorteCajaId_Internalname = "CORTECAJAID_"+sGXsfl_28_idx ;
            edtCorteCajaFechaD_Internalname = "CORTECAJAFECHAD_"+sGXsfl_28_idx ;
            edtCorteCajaFechaA_Internalname = "CORTECAJAFECHAA_"+sGXsfl_28_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_28_idx ;
         }
         /* End function sendrow_282 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         dynavCajacodigo_Internalname = "vCAJACODIGO" ;
         edtavCortecajafechadel_Internalname = "vCORTECAJAFECHADEL" ;
         edtavCortecajafechaal_Internalname = "vCORTECAJAFECHAAL" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttButton4_Internalname = "BUTTON4" ;
         bttButton5_Internalname = "BUTTON5" ;
         bttButton6_Internalname = "BUTTON6" ;
         bttButton7_Internalname = "BUTTON7" ;
         bttButton8_Internalname = "BUTTON8" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtUsuarioCodigo_Jsonclick = "" ;
         edtCorteCajaFechaA_Jsonclick = "" ;
         edtCorteCajaFechaD_Jsonclick = "" ;
         edtCorteCajaId_Jsonclick = "" ;
         edtCajaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavCortecajafechaal_Jsonclick = "" ;
         edtavCortecajafechadel_Jsonclick = "" ;
         dynavCajacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Linesfont = "font-family:Microsoft YaHei UI;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Microsoft YaHei UI;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Cortes de caja" ;
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
         AV6ClinicaCodigo = "" ;
         Gx_date = DateTime.MinValue ;
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
         edtCajaCodigo_Internalname = "" ;
         edtCorteCajaId_Internalname = "" ;
         edtCorteCajaFechaD_Internalname = "" ;
         edtCorteCajaFechaA_Internalname = "" ;
         edtUsuarioCodigo_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A132CajaCodigo = "" ;
         A278CorteCajaFechaD = (DateTime)(DateTime.MinValue) ;
         A279CorteCajaFechaA = (DateTime)(DateTime.MinValue) ;
         A4UsuarioCodigo = "" ;
         GXKey = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         AV9CajaCodigo = "" ;
         scmdbuf = "" ;
         H002Y2_A132CajaCodigo = new String[] {""} ;
         H002Y2_A133CajaDescripcion = new String[] {""} ;
         H002Y2_A41ClinicaCodigo = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         H002Y3_A4UsuarioCodigo = new String[] {""} ;
         H002Y3_A279CorteCajaFechaA = new DateTime[] {DateTime.MinValue} ;
         H002Y3_A278CorteCajaFechaD = new DateTime[] {DateTime.MinValue} ;
         H002Y3_A153CorteCajaId = new int[1] ;
         H002Y3_A132CajaCodigo = new String[] {""} ;
         H002Y3_A41ClinicaCodigo = new String[] {""} ;
         H002Y4_AGRID1_nRecordCount = new int[1] ;
         AV7CorteCajaFechaDel = DateTime.MinValue ;
         AV8CorteCajaFechaAl = DateTime.MinValue ;
         AV5Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         AV10UsuarioCodigo = "" ;
         bttButton6_Jsonclick = "" ;
         GXEncryptionTmp = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char6 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         bttButton5_Jsonclick = "" ;
         bttButton7_Jsonclick = "" ;
         bttButton8_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         GXt_char7 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_cortecaja__default(),
            new Object[][] {
                new Object[] {
               H002Y2_A132CajaCodigo, H002Y2_A133CajaDescripcion, H002Y2_A41ClinicaCodigo
               }
               , new Object[] {
               H002Y3_A4UsuarioCodigo, H002Y3_A279CorteCajaFechaA, H002Y3_A278CorteCajaFechaD, H002Y3_A153CorteCajaId, H002Y3_A132CajaCodigo, H002Y3_A41ClinicaCodigo
               }
               , new Object[] {
               H002Y4_AGRID1_nRecordCount
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
      private short nGXsfl_28_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid1_Rows ;
      private short GXt_int5 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize28 ;
      private int GRID1_nFirstRecordOnPage ;
      private int A153CorteCajaId ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_28_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtClinicaCodigo_Internalname ;
      private String edtCajaCodigo_Internalname ;
      private String edtCorteCajaId_Internalname ;
      private String edtCorteCajaFechaD_Internalname ;
      private String edtCorteCajaFechaA_Internalname ;
      private String edtUsuarioCodigo_Internalname ;
      private String GXKey ;
      private String dynavCajacodigo_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavCortecajafechadel_Internalname ;
      private String edtavCortecajafechaal_Internalname ;
      private String subGrid1_Internalname ;
      private String bttButton6_Jsonclick ;
      private String bttButton6_Internalname ;
      private String GXEncryptionTmp ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char6 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String bttButton5_Internalname ;
      private String bttButton5_Jsonclick ;
      private String bttButton7_Internalname ;
      private String bttButton7_Jsonclick ;
      private String bttButton8_Internalname ;
      private String bttButton8_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String dynavCajacodigo_Jsonclick ;
      private String edtavCortecajafechadel_Jsonclick ;
      private String edtavCortecajafechaal_Jsonclick ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtCajaCodigo_Jsonclick ;
      private String edtCorteCajaId_Jsonclick ;
      private String edtCorteCajaFechaD_Jsonclick ;
      private String edtCorteCajaFechaA_Jsonclick ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String GXt_char9 ;
      private DateTime A278CorteCajaFechaD ;
      private DateTime A279CorteCajaFechaA ;
      private DateTime Gx_date ;
      private DateTime AV7CorteCajaFechaDel ;
      private DateTime AV8CorteCajaFechaAl ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6ClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A132CajaCodigo ;
      private String A4UsuarioCodigo ;
      private String AV9CajaCodigo ;
      private String AV10UsuarioCodigo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavCajacodigo ;
      private IDataStoreProvider pr_default ;
      private String[] H002Y2_A132CajaCodigo ;
      private String[] H002Y2_A133CajaDescripcion ;
      private String[] H002Y2_A41ClinicaCodigo ;
      private String[] H002Y3_A4UsuarioCodigo ;
      private DateTime[] H002Y3_A279CorteCajaFechaA ;
      private DateTime[] H002Y3_A278CorteCajaFechaD ;
      private int[] H002Y3_A153CorteCajaId ;
      private String[] H002Y3_A132CajaCodigo ;
      private String[] H002Y3_A41ClinicaCodigo ;
      private int[] H002Y4_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV5Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class wp_cortecaja__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002Y2 ;
          prmH002Y2 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH002Y3 ;
          prmH002Y3 = new Object[] {
          } ;
          Object[] prmH002Y4 ;
          prmH002Y4 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H002Y2", "SELECT [CajaCodigo], [CajaDescripcion], [ClinicaCodigo] FROM [Caja] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV6ClinicaCodigo ORDER BY [CajaDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Y2,0,0,true,false )
             ,new CursorDef("H002Y3", "SELECT [UsuarioCodigo], [CorteCajaFechaA], [CorteCajaFechaD], [CorteCajaId], [CajaCodigo], [ClinicaCodigo] FROM [CorteCaja] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [CajaCodigo], [CorteCajaId]  OPTION (FAST 13)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Y3,13,0,true,false )
             ,new CursorDef("H002Y4", "SELECT COUNT(*) FROM [CorteCaja] WITH (NOLOCK) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002Y4,1,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDateTime(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
       }
    }

 }

}
