/*
               File: wp_registramovinv
        Description: Registra Movimiento de Inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:4.60
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
   public class wp_registramovinv : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_registramovinv( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_registramovinv( IGxContext context )
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
         dynavBodegacodigo = new GXCombobox();
         dynavTipomicodigo = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vBODEGACODIGO") == 0 )
            {
               AV6ClinicaCodigo = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLVvBODEGACODIGO342( AV6ClinicaCodigo) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vTIPOMICODIGO") == 0 )
            {
               AV6ClinicaCodigo = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLVvTIPOMICODIGO342( AV6ClinicaCodigo) ;
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
               nGXsfl_85_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_85_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_85_idx, sGXsfl_85_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               Gx_time = context.localUtil.Time( ) ;
               Gx_date = DateTimeUtil.Today( ) ;
               context.Gx_err = 0 ;
               dynavBodegacodigo.Name = "vBODEGACODIGO" ;
               dynavBodegacodigo.WebTags = "" ;
               dynavTipomicodigo.Name = "vTIPOMICODIGO" ;
               dynavTipomicodigo.WebTags = "" ;
               AV8TipoMICodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
               AV6ClinicaCodigo = GetNextPar( ) ;
               AV9MovimientoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( AV8TipoMICodigo, AV6ClinicaCodigo, AV9MovimientoId) ;
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
         PA342( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START342( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_registramovinv.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vTIPOMICODIGO", StringUtil.RTrim( AV8TipoMICodigo));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
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
            WE342( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT342( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_registramovinv" ;
      }

      public override String GetPgmdesc( )
      {
         return "Registra Movimiento de Inventario" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_registramovinv.aspx")  ;
      }

      protected void WB340( )
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
            wb_table1_2_342( true) ;
         }
         else
         {
            wb_table1_2_342( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_342e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Fecha Del", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Fecha Del", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
         }
         wbLoad = true ;
      }

      protected void START342( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Registra Movimiento de Inventario", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP340( ) ;
      }

      protected void WS342( )
      {
         START342( ) ;
         EVT342( ) ;
      }

      protected void EVT342( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'CORRELATIVO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11342 */
                              E11342 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12342 */
                              E12342 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'AGREGAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E13342 */
                              E13342 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'VALIDAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E14342 */
                              E14342 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'IMPRIMIR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E15342 */
                              E15342 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CONFIRMAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E16342 */
                              E16342 ();
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
                              nGXsfl_85_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_85_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_85_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_85_idx ;
                              edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_85_idx ;
                              edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_85_idx ;
                              edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_85_idx ;
                              edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_85_idx ;
                              edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_85_idx ;
                              edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_85_idx ;
                              edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_85_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A114TipoMICodigo = cgiGet( edtTipoMICodigo_Internalname) ;
                              A267MovimientoId = (int)(context.localUtil.CToN( cgiGet( edtMovimientoId_Internalname), ".", ",")) ;
                              A272MovimientoLinea = (short)(context.localUtil.CToN( cgiGet( edtMovimientoLinea_Internalname), ".", ",")) ;
                              A30ArticuloCodigo = cgiGet( edtArticuloCodigo_Internalname) ;
                              A273MovimientoCantidad = context.localUtil.CToN( cgiGet( edtMovimientoCantidad_Internalname), ".", ",") ;
                              A274MovimientoCosto = context.localUtil.CToN( cgiGet( edtMovimientoCosto_Internalname), ".", ",") ;
                              A275MovimientoCostoTotal = context.localUtil.CToN( cgiGet( edtMovimientoCostoTotal_Internalname), ".", ",") ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E17342 */
                                    E17342 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E18342 */
                                    E18342 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Tipomicodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTIPOMICODIGO"), AV8TipoMICodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
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

      protected void WE342( )
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

      protected void PA342( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            dynavBodegacodigo.Name = "vBODEGACODIGO" ;
            dynavBodegacodigo.WebTags = "" ;
            dynavTipomicodigo.Name = "vTIPOMICODIGO" ;
            dynavTipomicodigo.WebTags = "" ;
            GX_FocusControl = dynavBodegacodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvBODEGACODIGO342( String AV6ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvBODEGACODIGO_data342( AV6ClinicaCodigo) ;
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

      protected void GXVvBODEGACODIGO_html342( String AV6ClinicaCodigo )
      {
         String gxdynajaxvalue ;
         GXDLVvBODEGACODIGO_data342( AV6ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynavBodegacodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynavBodegacodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavBodegacodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV7BodegaCodigo)) )
            {
               AV7BodegaCodigo = dynavBodegacodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BodegaCodigo", AV7BodegaCodigo);
            }
         }
      }

      protected void GXDLVvBODEGACODIGO_data342( String AV6ClinicaCodigo )
      {
         /* Using cursor H00342 */
         pr_default.execute(0, new Object[] {AV6ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H00342_A121BodegaCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H00342_A122BodegaDescripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvTIPOMICODIGO342( String AV6ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvTIPOMICODIGO_data342( AV6ClinicaCodigo) ;
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

      protected void GXVvTIPOMICODIGO_html342( String AV6ClinicaCodigo )
      {
         String gxdynajaxvalue ;
         GXDLVvTIPOMICODIGO_data342( AV6ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynavTipomicodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynavTipomicodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavTipomicodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV8TipoMICodigo)) )
            {
               AV8TipoMICodigo = dynavTipomicodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
            }
         }
      }

      protected void GXDLVvTIPOMICODIGO_data342( String AV6ClinicaCodigo )
      {
         /* Using cursor H00343 */
         pr_default.execute(1, new Object[] {AV6ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H00343_A114TipoMICodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H00343_A115TipoMIDescripcion[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_85_idx ,
                                       String sGXsfl_85_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_85_idx ;
         edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_85_idx ;
         edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_85_idx ;
         edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_85_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_85_idx ;
         edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_85_idx ;
         edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_85_idx ;
         edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_85_idx ;
         while ( nGXsfl_85_idx <= nRC_Grid1 )
         {
            sendrow_852( ) ;
            nGXsfl_85_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_85_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_85_idx+1)) ;
            sGXsfl_85_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_85_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_85_idx ;
            edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_85_idx ;
            edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_85_idx ;
            edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_85_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_85_idx ;
            edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_85_idx ;
            edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_85_idx ;
            edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_85_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String AV8TipoMICodigo ,
                                        String AV6ClinicaCodigo ,
                                        int AV9MovimientoId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF342( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF342( ) ;
         /* End function Refresh */
      }

      protected void RF342( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 85 ;
         nGXsfl_85_idx = 1 ;
         sGXsfl_85_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_85_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_85_idx ;
         edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_85_idx ;
         edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_85_idx ;
         edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_85_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_85_idx ;
         edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_85_idx ;
         edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_85_idx ;
         edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_85_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_85_idx ;
            edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_85_idx ;
            edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_85_idx ;
            edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_85_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_85_idx ;
            edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_85_idx ;
            edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_85_idx ;
            edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_85_idx ;
            /* Using cursor H00344 */
            pr_default.execute(2, new Object[] {AV6ClinicaCodigo, AV8TipoMICodigo, AV9MovimientoId});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A30ArticuloCodigo = H00344_A30ArticuloCodigo[0] ;
               A272MovimientoLinea = H00344_A272MovimientoLinea[0] ;
               A267MovimientoId = H00344_A267MovimientoId[0] ;
               A114TipoMICodigo = H00344_A114TipoMICodigo[0] ;
               A41ClinicaCodigo = H00344_A41ClinicaCodigo[0] ;
               A274MovimientoCosto = H00344_A274MovimientoCosto[0] ;
               A273MovimientoCantidad = H00344_A273MovimientoCantidad[0] ;
               A275MovimientoCostoTotal = (decimal)((A273MovimientoCantidad*A274MovimientoCosto)) ;
               /* Execute user event: E18342 */
               E18342 ();
               pr_default.readNext(2);
            }
            pr_default.close(2);
            wbEnd = 85 ;
            WB340( ) ;
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

      protected void STRUP340( )
      {
         /* Before Start, stand alone formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         edtavMovimientoid_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMovimientoid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMovimientoid_Enabled), 5, 0)));
         edtavMovimientofecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMovimientofecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMovimientofecha_Enabled), 5, 0)));
         edtavMovimientohora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavMovimientohora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMovimientohora_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E17342 */
         E17342 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         GXVvBODEGACODIGO_html342( AV6ClinicaCodigo) ;
         GXVvTIPOMICODIGO_html342( AV6ClinicaCodigo) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            dynavBodegacodigo.Name = dynavBodegacodigo_Internalname ;
            dynavBodegacodigo.CurrentValue = cgiGet( dynavBodegacodigo_Internalname) ;
            AV7BodegaCodigo = cgiGet( dynavBodegacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BodegaCodigo", AV7BodegaCodigo);
            dynavTipomicodigo.Name = dynavTipomicodigo_Internalname ;
            dynavTipomicodigo.CurrentValue = cgiGet( dynavTipomicodigo_Internalname) ;
            AV8TipoMICodigo = cgiGet( dynavTipomicodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
            AV9MovimientoId = (int)(context.localUtil.CToN( cgiGet( edtavMovimientoid_Internalname), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
            AV10MovimientoFecha = context.localUtil.CToD( cgiGet( edtavMovimientofecha_Internalname), 2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10MovimientoFecha", context.localUtil.Format(AV10MovimientoFecha, "99/99/99"));
            AV11MovimientoHora = cgiGet( edtavMovimientohora_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11MovimientoHora", AV11MovimientoHora);
            AV12MovimientoReferencia = cgiGet( edtavMovimientoreferencia_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12MovimientoReferencia", AV12MovimientoReferencia);
            AV13MovimientoObs = cgiGet( edtavMovimientoobs_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13MovimientoObs", AV13MovimientoObs);
            AV15ArticuloCodigo = cgiGet( edtavArticulocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ArticuloCodigo", AV15ArticuloCodigo);
            AV16ArticuloDescripcion = cgiGet( edtavArticulodescripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ArticuloDescripcion", AV16ArticuloDescripcion);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMovimientocosto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMovimientocosto_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMOVIMIENTOCOSTO");
               GX_FocusControl = edtavMovimientocosto_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV17MovimientoCosto = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17MovimientoCosto", StringUtil.LTrim( StringUtil.Str( AV17MovimientoCosto, 17, 2)));
            }
            else
            {
               AV17MovimientoCosto = context.localUtil.CToN( cgiGet( edtavMovimientocosto_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17MovimientoCosto", StringUtil.LTrim( StringUtil.Str( AV17MovimientoCosto, 17, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavMovimientocantidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavMovimientocantidad_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vMOVIMIENTOCANTIDAD");
               GX_FocusControl = edtavMovimientocantidad_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV18MovimientoCantidad = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18MovimientoCantidad", StringUtil.LTrim( StringUtil.Str( AV18MovimientoCantidad, 17, 2)));
            }
            else
            {
               AV18MovimientoCantidad = context.localUtil.CToN( cgiGet( edtavMovimientocantidad_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18MovimientoCantidad", StringUtil.LTrim( StringUtil.Str( AV18MovimientoCantidad, 17, 2)));
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
         /* Execute user event: E17342 */
         E17342 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17342( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV5Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV5Parametros = GXt_SdtParametros4 ;
         AV6ClinicaCodigo = AV5Parametros.gxTpr_Pclinicacodigo ;
         AV14UsuarioCodigo = AV5Parametros.gxTpr_Pusuariocodigo ;
         bttButton6_Jsonclick = "confirm('¿Seguro de confirmar el movimiento de inventario?')" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton6_Internalname, "Jsonclick", bttButton6_Jsonclick);
      }

      protected void E11342( )
      {
         /* 'Correlativo' Routine */
         if ( AV9MovimientoId == 0 )
         {
            GXt_int5 = AV9MovimientoId ;
            new oobtienecorrelativomovinv(context ).execute(  AV6ClinicaCodigo,  AV8TipoMICodigo, out  GXt_int5) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
            AV9MovimientoId = GXt_int5 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
            AV10MovimientoFecha = Gx_date ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10MovimientoFecha", context.localUtil.Format(AV10MovimientoFecha, "99/99/99"));
            AV11MovimientoHora = Gx_time ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11MovimientoHora", AV11MovimientoHora);
         }
      }

      protected void E12342( )
      {
         /* 'Regresar' Routine */
         context.wjLoc = formatLink("wp_movimientoinv.aspx")  ;
      }

      protected void E13342( )
      {
         /* 'Agregar' Routine */
         GXt_int6 = AV19MovimientoEstado ;
         new oobtienemovinvestado(context ).execute(  AV6ClinicaCodigo,  AV8TipoMICodigo,  AV9MovimientoId, out  GXt_int6) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
         AV19MovimientoEstado = GXt_int6 ;
         if ( AV19MovimientoEstado == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV16ArticuloDescripcion)) )
            {
               GX_msglist.addItem("Debe seleccionar un artículo válido.");
            }
            else
            {
               if ( (Convert.ToDecimal(0)==AV18MovimientoCantidad) )
               {
                  GX_msglist.addItem("Debe ingresar cantidad válida.");
               }
               else
               {
                  if ( ( AV18MovimientoCantidad > Convert.ToDecimal( 0 )) )
                  {
                     GXt_int6 = 0 ;
                     new pregistramovinv(context ).execute( ref  AV6ClinicaCodigo, ref  AV8TipoMICodigo, ref  AV9MovimientoId, ref  AV10MovimientoFecha, ref  AV11MovimientoHora, ref  AV7BodegaCodigo, ref  AV12MovimientoReferencia, ref  AV13MovimientoObs, ref  AV14UsuarioCodigo, ref  GXt_int6) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10MovimientoFecha", context.localUtil.Format(AV10MovimientoFecha, "99/99/99"));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11MovimientoHora", AV11MovimientoHora);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BodegaCodigo", AV7BodegaCodigo);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12MovimientoReferencia", AV12MovimientoReferencia);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13MovimientoObs", AV13MovimientoObs);
                     new pregistramovinvdetalle(context ).execute( ref  AV6ClinicaCodigo, ref  AV8TipoMICodigo, ref  AV9MovimientoId, ref  AV15ArticuloCodigo, ref  AV18MovimientoCantidad, ref  AV17MovimientoCosto) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ArticuloCodigo", AV15ArticuloCodigo);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18MovimientoCantidad", StringUtil.LTrim( StringUtil.Str( AV18MovimientoCantidad, 17, 2)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17MovimientoCosto", StringUtil.LTrim( StringUtil.Str( AV17MovimientoCosto, 17, 2)));
                  }
                  else
                  {
                     GX_msglist.addItem("Cantidad debe ser mayor a cero.");
                  }
               }
            }
         }
         else
         {
            GX_msglist.addItem("Estado de movimiento ya fue confirmado. No puede agregar más artículos.");
         }
      }

      protected void E14342( )
      {
         /* 'Validar' Routine */
         GXt_int6 = AV19MovimientoEstado ;
         new oobtienemovinvestado(context ).execute(  AV6ClinicaCodigo,  AV8TipoMICodigo,  AV9MovimientoId, out  GXt_int6) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
         AV19MovimientoEstado = GXt_int6 ;
         if ( AV19MovimientoEstado == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV15ArticuloCodigo)) )
            {
               GX_msglist.addItem("Artículo no puede estar en blanco.");
            }
            else
            {
               new oobtienearticulocosto(context ).execute( ref  AV6ClinicaCodigo, ref  AV15ArticuloCodigo, ref  AV16ArticuloDescripcion, ref  AV17MovimientoCosto) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ArticuloCodigo", AV15ArticuloCodigo);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ArticuloDescripcion", AV16ArticuloDescripcion);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17MovimientoCosto", StringUtil.LTrim( StringUtil.Str( AV17MovimientoCosto, 17, 2)));
            }
         }
         else
         {
            GX_msglist.addItem("Estado de movimiento ya fue confirmado. No puede agregar más artículos.");
         }
      }

      protected void E15342( )
      {
         /* 'Imprimir' Routine */
         GXt_int6 = AV19MovimientoEstado ;
         new oobtienemovinvestado(context ).execute(  AV6ClinicaCodigo,  AV8TipoMICodigo,  AV9MovimientoId, out  GXt_int6) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
         AV19MovimientoEstado = GXt_int6 ;
         if ( AV19MovimientoEstado == 1 )
         {
         }
         else
         {
            GX_msglist.addItem("Estado de movimiento no ha sido confirmado. No puede generar la impresión.");
         }
      }

      protected void E16342( )
      {
         /* 'Confirmar' Routine */
         GXt_int6 = AV19MovimientoEstado ;
         new oobtienemovinvestado(context ).execute(  AV6ClinicaCodigo,  AV8TipoMICodigo,  AV9MovimientoId, out  GXt_int6) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
         AV19MovimientoEstado = GXt_int6 ;
         if ( AV19MovimientoEstado == 0 )
         {
            GXt_int6 = 1 ;
            new pregistramovinv(context ).execute( ref  AV6ClinicaCodigo, ref  AV8TipoMICodigo, ref  AV9MovimientoId, ref  AV10MovimientoFecha, ref  AV11MovimientoHora, ref  AV7BodegaCodigo, ref  AV12MovimientoReferencia, ref  AV13MovimientoObs, ref  AV14UsuarioCodigo, ref  GXt_int6) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10MovimientoFecha", context.localUtil.Format(AV10MovimientoFecha, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11MovimientoHora", AV11MovimientoHora);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BodegaCodigo", AV7BodegaCodigo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12MovimientoReferencia", AV12MovimientoReferencia);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13MovimientoObs", AV13MovimientoObs);
            new pactualizaexistencias(context ).execute( ref  AV6ClinicaCodigo, ref  AV8TipoMICodigo, ref  AV9MovimientoId) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
         }
         else
         {
            GX_msglist.addItem("Estado de movimiento no ha sido confirmado. No puede generar la impresión.");
         }
      }

      private void E18342( )
      {
         /* Load Routine */
         sendrow_852( ) ;
      }

      protected void wb_table1_2_342( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:37px\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:16px\">") ;
            wb_table2_10_342( true) ;
         }
         else
         {
            wb_table2_10_342( false) ;
         }
         return  ;
      }

      protected void wb_table2_10_342e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table3_32_342( true) ;
         }
         else
         {
            wb_table3_32_342( false) ;
         }
         return  ;
      }

      protected void wb_table3_32_342e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table4_44_342( true) ;
         }
         else
         {
            wb_table4_44_342( false) ;
         }
         return  ;
      }

      protected void wb_table4_44_342e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table5_57_342( true) ;
         }
         else
         {
            wb_table5_57_342( false) ;
         }
         return  ;
      }

      protected void wb_table5_57_342e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"85\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Tipo_Movimiento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Línea") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Artículo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cantidad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Costo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
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
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A114TipoMICodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A267MovimientoId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A272MovimientoLinea), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A30ArticuloCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A273MovimientoCantidad, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A274MovimientoCosto, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A275MovimientoCostoTotal, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 85 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_85_idx-1) ;
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
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton6_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(85), 3, 0)+","+"null"+");", "Confirmar", bttButton6_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, 1, 1, "standard", "E\\'CONFIRMAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton5_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(85), 3, 0)+","+"null"+");", "Imprimir", bttButton5_Jsonclick, 5, "Imprimir", "", StyleString, ClassString, 1, 1, "standard", "E\\'IMPRIMIR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(85), 3, 0)+","+"null"+");", "Regresar", bttButton2_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_342e( true) ;
         }
         else
         {
            wb_table1_2_342e( false) ;
         }
      }

      protected void wb_table5_57_342( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock15_Internalname, "Artículo", "", "", lblTextblock15_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock14_Internalname, "Descripción", "", "", lblTextblock14_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, "Costo Unitario", "", "", lblTextblock13_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, "Cantidad", "", "", lblTextblock12_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ArticuloCodigo", AV15ArticuloCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_85_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavArticulocodigo_Internalname, StringUtil.RTrim( AV15ArticuloCodigo), StringUtil.RTrim( context.localUtil.Format( AV15ArticuloCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(71);\"", "", "", "", "", edtavArticulocodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "&nbsp;") ;
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, context.GetImagePath( "1ea517ed-e3a8-4cbc-ab4d-4e42dd1ae5e8", "", "Fantastic"), "", "", "", "Fantastic", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton4_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(85), 3, 0)+","+"null"+");", ">|", bttButton4_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'VALIDAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ArticuloDescripcion", AV16ArticuloDescripcion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_85_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavArticulodescripcion_Internalname, StringUtil.RTrim( AV16ArticuloDescripcion), StringUtil.RTrim( context.localUtil.Format( AV16ArticuloDescripcion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(76);\"", "", "", "", "", edtavArticulodescripcion_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17MovimientoCosto", StringUtil.LTrim( StringUtil.Str( AV17MovimientoCosto, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_85_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavMovimientocosto_Internalname, StringUtil.LTrim( StringUtil.NToC( AV17MovimientoCosto, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV17MovimientoCosto, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV17MovimientoCosto, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(78);\"", "", "", "", "", edtavMovimientocosto_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18MovimientoCantidad", StringUtil.LTrim( StringUtil.Str( AV18MovimientoCantidad, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_85_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavMovimientocantidad_Internalname, StringUtil.LTrim( StringUtil.NToC( AV18MovimientoCantidad, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV18MovimientoCantidad, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV18MovimientoCantidad, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(80);\"", "", "", "", "", edtavMovimientocantidad_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(85), 3, 0)+","+"null"+");", ">|", bttButton3_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'AGREGAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_57_342e( true) ;
         }
         else
         {
            wb_table5_57_342e( false) ;
         }
      }

      protected void wb_table4_44_342( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Referencia", "", "", lblTextblock6_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12MovimientoReferencia", AV12MovimientoReferencia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_85_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavMovimientoreferencia_Internalname, StringUtil.RTrim( AV12MovimientoReferencia), StringUtil.RTrim( context.localUtil.Format( AV12MovimientoReferencia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(49);\"", "", "", "", "", edtavMovimientoreferencia_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Observaciones", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13MovimientoObs", AV13MovimientoObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_85_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_html_textarea( context, edtavMovimientoobs_Internalname, StringUtil.RTrim( AV13MovimientoObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(54);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_44_342e( true) ;
         }
         else
         {
            wb_table4_44_342e( false) ;
         }
      }

      protected void wb_table3_32_342( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "Fecha", "", "", lblTextblock8_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10MovimientoFecha", context.localUtil.Format(AV10MovimientoFecha, "99/99/99"));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavMovimientofecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavMovimientofecha_Internalname, context.localUtil.Format(AV10MovimientoFecha, "99/99/99"), context.localUtil.Format( AV10MovimientoFecha, "99/99/99"), "", "", "", "", "", edtavMovimientofecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtavMovimientofecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registramovinv.htm");
            GxWebStd.gx_bitmap( context, edtavMovimientofecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtavMovimientofecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_registramovinv.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "Hora", "", "", lblTextblock7_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11MovimientoHora", AV11MovimientoHora);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavMovimientohora_Internalname, StringUtil.RTrim( AV11MovimientoHora), StringUtil.RTrim( context.localUtil.Format( AV11MovimientoHora, "XXXXXXXX")), "", "", "", "", "", edtavMovimientohora_Jsonclick, 0, ClassString, StyleString, "", 1, edtavMovimientohora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_32_342e( true) ;
         }
         else
         {
            wb_table3_32_342e( false) ;
         }
      }

      protected void wb_table2_10_342( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, "Bodega", "", "", lblTextblock11_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BodegaCodigo", AV7BodegaCodigo);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'" + sGXsfl_85_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavBodegacodigo, dynavBodegacodigo_Internalname, AV7BodegaCodigo, 1, dynavBodegacodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(15);\"", "", true, "HLP_wp_registramovinv.htm");
            dynavBodegacodigo.CurrentValue = AV7BodegaCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavBodegacodigo_Internalname, "Values", (String)(dynavBodegacodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, "Tipo Movimiento", "", "", lblTextblock10_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TipoMICodigo", AV8TipoMICodigo);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'" + sGXsfl_85_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavTipomicodigo, dynavTipomicodigo_Internalname, AV8TipoMICodigo, 1, dynavTipomicodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 80, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(21);\"", "", true, "HLP_wp_registramovinv.htm");
            dynavTipomicodigo.CurrentValue = AV8TipoMICodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavTipomicodigo_Internalname, "Values", (String)(dynavTipomicodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(85), 3, 0)+","+"null"+");", ">|", bttButton1_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'CORRELATIVO\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, "Movimiento Id", "", "", lblTextblock9_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9MovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9MovimientoId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavMovimientoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9MovimientoId), 9, 0, ".", "")), ((edtavMovimientoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9MovimientoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV9MovimientoId), "ZZZZZZZZ9")), "", "", "", "", "", edtavMovimientoid_Jsonclick, 0, ClassString, StyleString, "", 1, edtavMovimientoid_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registramovinv.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_342e( true) ;
         }
         else
         {
            wb_table2_10_342e( false) ;
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
         PA342( ) ;
         WS342( ) ;
         WE342( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?158591");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("wp_registramovinv.js", "?158592");
         /* End function include_jscripts */
      }

      protected void sendrow_852( )
      {
         WB340( ) ;
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
            if ( ((int)(nGXsfl_85_idx) % (2)) == 0 )
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
            context.WriteHtmlText( " gxrow=\""+sGXsfl_85_idx+"\">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)85,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoMICodigo_Internalname,StringUtil.RTrim( A114TipoMICodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoMICodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)85,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A267MovimientoId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A267MovimientoId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)85,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoLinea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A272MovimientoLinea), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A272MovimientoLinea), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoLinea_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)85,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloCodigo_Internalname,StringUtil.RTrim( A30ArticuloCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)85,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A273MovimientoCantidad, 17, 2, ".", "")),context.localUtil.Format( A273MovimientoCantidad, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoCantidad_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)85,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoCosto_Internalname,StringUtil.LTrim( StringUtil.NToC( A274MovimientoCosto, 17, 2, ".", "")),context.localUtil.Format( A274MovimientoCosto, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoCosto_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)85,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoCostoTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A275MovimientoCostoTotal, 17, 2, ".", "")),context.localUtil.Format( A275MovimientoCostoTotal, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoCostoTotal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)85,(short)1,(short)1,(bool)true,(String)"right"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_85_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_85_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_85_idx+1)) ;
         sGXsfl_85_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_85_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_85_idx ;
         edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_85_idx ;
         edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_85_idx ;
         edtMovimientoLinea_Internalname = "MOVIMIENTOLINEA_"+sGXsfl_85_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_85_idx ;
         edtMovimientoCantidad_Internalname = "MOVIMIENTOCANTIDAD_"+sGXsfl_85_idx ;
         edtMovimientoCosto_Internalname = "MOVIMIENTOCOSTO_"+sGXsfl_85_idx ;
         edtMovimientoCostoTotal_Internalname = "MOVIMIENTOCOSTOTOTAL_"+sGXsfl_85_idx ;
         /* End function sendrow_852 */
      }

      protected void init_default_properties( )
      {
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         dynavBodegacodigo_Internalname = "vBODEGACODIGO" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         dynavTipomicodigo_Internalname = "vTIPOMICODIGO" ;
         bttButton1_Internalname = "BUTTON1" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         edtavMovimientoid_Internalname = "vMOVIMIENTOID" ;
         tblTable2_Internalname = "TABLE2" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtavMovimientofecha_Internalname = "vMOVIMIENTOFECHA" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtavMovimientohora_Internalname = "vMOVIMIENTOHORA" ;
         tblTable3_Internalname = "TABLE3" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavMovimientoreferencia_Internalname = "vMOVIMIENTOREFERENCIA" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavMovimientoobs_Internalname = "vMOVIMIENTOOBS" ;
         tblTable4_Internalname = "TABLE4" ;
         lblTextblock15_Internalname = "TEXTBLOCK15" ;
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         edtavArticulocodigo_Internalname = "vARTICULOCODIGO" ;
         imgImage1_Internalname = "IMAGE1" ;
         bttButton4_Internalname = "BUTTON4" ;
         edtavArticulodescripcion_Internalname = "vARTICULODESCRIPCION" ;
         edtavMovimientocosto_Internalname = "vMOVIMIENTOCOSTO" ;
         edtavMovimientocantidad_Internalname = "vMOVIMIENTOCANTIDAD" ;
         bttButton3_Internalname = "BUTTON3" ;
         tblTable5_Internalname = "TABLE5" ;
         bttButton6_Internalname = "BUTTON6" ;
         bttButton5_Internalname = "BUTTON5" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable1_Internalname = "TABLE1" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtMovimientoCostoTotal_Jsonclick = "" ;
         edtMovimientoCosto_Jsonclick = "" ;
         edtMovimientoCantidad_Jsonclick = "" ;
         edtArticuloCodigo_Jsonclick = "" ;
         edtMovimientoLinea_Jsonclick = "" ;
         edtMovimientoId_Jsonclick = "" ;
         edtTipoMICodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavMovimientoid_Jsonclick = "" ;
         edtavMovimientoid_Enabled = 0 ;
         dynavTipomicodigo_Jsonclick = "" ;
         dynavBodegacodigo_Jsonclick = "" ;
         edtavMovimientohora_Jsonclick = "" ;
         edtavMovimientohora_Enabled = 0 ;
         edtavMovimientofecha_Jsonclick = "" ;
         edtavMovimientofecha_Enabled = 0 ;
         edtavMovimientoreferencia_Jsonclick = "" ;
         edtavMovimientocantidad_Jsonclick = "" ;
         edtavMovimientocosto_Jsonclick = "" ;
         edtavArticulodescripcion_Jsonclick = "" ;
         edtavArticulocodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Registra Movimiento de Inventario" ;
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
         Gx_time = "" ;
         Gx_date = DateTime.MinValue ;
         AV8TipoMICodigo = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtTipoMICodigo_Internalname = "" ;
         edtMovimientoId_Internalname = "" ;
         edtMovimientoLinea_Internalname = "" ;
         edtArticuloCodigo_Internalname = "" ;
         edtMovimientoCantidad_Internalname = "" ;
         edtMovimientoCosto_Internalname = "" ;
         edtMovimientoCostoTotal_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A114TipoMICodigo = "" ;
         A30ArticuloCodigo = "" ;
         GXKey = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         AV7BodegaCodigo = "" ;
         scmdbuf = "" ;
         H00342_A121BodegaCodigo = new String[] {""} ;
         H00342_A122BodegaDescripcion = new String[] {""} ;
         H00342_A41ClinicaCodigo = new String[] {""} ;
         H00342_A123BodegaEstado = new short[1] ;
         H00343_A114TipoMICodigo = new String[] {""} ;
         H00343_A115TipoMIDescripcion = new String[] {""} ;
         H00343_A41ClinicaCodigo = new String[] {""} ;
         H00343_A287TipoMIRestringe = new short[1] ;
         H00343_A118TipoMIEstado = new short[1] ;
         Grid1Container = new GXWebGrid( context);
         H00344_A30ArticuloCodigo = new String[] {""} ;
         H00344_A272MovimientoLinea = new short[1] ;
         H00344_A267MovimientoId = new int[1] ;
         H00344_A114TipoMICodigo = new String[] {""} ;
         H00344_A41ClinicaCodigo = new String[] {""} ;
         H00344_A274MovimientoCosto = new decimal[1] ;
         H00344_A273MovimientoCantidad = new decimal[1] ;
         AV10MovimientoFecha = DateTime.MinValue ;
         AV11MovimientoHora = "" ;
         AV12MovimientoReferencia = "" ;
         AV13MovimientoObs = "" ;
         AV15ArticuloCodigo = "" ;
         AV16ArticuloDescripcion = "" ;
         AV5Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         AV14UsuarioCodigo = "" ;
         bttButton6_Jsonclick = "" ;
         sStyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char10 = "" ;
         TempTags = "" ;
         bttButton5_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         lblTextblock15_Jsonclick = "" ;
         lblTextblock14_Jsonclick = "" ;
         lblTextblock13_Jsonclick = "" ;
         lblTextblock12_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         lblTextblock9_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char11 = "" ;
         ROClassString = "" ;
         GXt_char12 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_registramovinv__default(),
            new Object[][] {
                new Object[] {
               H00342_A121BodegaCodigo, H00342_A122BodegaDescripcion, H00342_A41ClinicaCodigo, H00342_A123BodegaEstado
               }
               , new Object[] {
               H00343_A114TipoMICodigo, H00343_A115TipoMIDescripcion, H00343_A41ClinicaCodigo, H00343_A287TipoMIRestringe, H00343_A118TipoMIEstado
               }
               , new Object[] {
               H00344_A30ArticuloCodigo, H00344_A272MovimientoLinea, H00344_A267MovimientoId, H00344_A114TipoMICodigo, H00344_A41ClinicaCodigo, H00344_A274MovimientoCosto, H00344_A273MovimientoCantidad
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

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_85_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short A272MovimientoLinea ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV19MovimientoEstado ;
      private short GXt_int6 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV9MovimientoId ;
      private int A267MovimientoId ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int edtavMovimientoid_Enabled ;
      private int edtavMovimientofecha_Enabled ;
      private int edtavMovimientohora_Enabled ;
      private int GXt_int5 ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal A273MovimientoCantidad ;
      private decimal A274MovimientoCosto ;
      private decimal A275MovimientoCostoTotal ;
      private decimal AV17MovimientoCosto ;
      private decimal AV18MovimientoCantidad ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_85_idx="0001" ;
      private String Gx_time ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtClinicaCodigo_Internalname ;
      private String edtTipoMICodigo_Internalname ;
      private String edtMovimientoId_Internalname ;
      private String edtMovimientoLinea_Internalname ;
      private String edtArticuloCodigo_Internalname ;
      private String edtMovimientoCantidad_Internalname ;
      private String edtMovimientoCosto_Internalname ;
      private String edtMovimientoCostoTotal_Internalname ;
      private String GXKey ;
      private String dynavBodegacodigo_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavMovimientoid_Internalname ;
      private String edtavMovimientofecha_Internalname ;
      private String edtavMovimientohora_Internalname ;
      private String dynavTipomicodigo_Internalname ;
      private String AV11MovimientoHora ;
      private String edtavMovimientoreferencia_Internalname ;
      private String edtavMovimientoobs_Internalname ;
      private String edtavArticulocodigo_Internalname ;
      private String edtavArticulodescripcion_Internalname ;
      private String edtavMovimientocosto_Internalname ;
      private String edtavMovimientocantidad_Internalname ;
      private String bttButton6_Jsonclick ;
      private String bttButton6_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String TempTags ;
      private String bttButton5_Internalname ;
      private String bttButton5_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String tblTable5_Internalname ;
      private String lblTextblock15_Internalname ;
      private String lblTextblock15_Jsonclick ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String edtavArticulocodigo_Jsonclick ;
      private String imgImage1_Internalname ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String edtavArticulodescripcion_Jsonclick ;
      private String edtavMovimientocosto_Jsonclick ;
      private String edtavMovimientocantidad_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavMovimientoreferencia_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtavMovimientofecha_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtavMovimientohora_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String dynavBodegacodigo_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String dynavTipomicodigo_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtavMovimientoid_Jsonclick ;
      private String GXt_char11 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtTipoMICodigo_Jsonclick ;
      private String edtMovimientoId_Jsonclick ;
      private String edtMovimientoLinea_Jsonclick ;
      private String edtArticuloCodigo_Jsonclick ;
      private String edtMovimientoCantidad_Jsonclick ;
      private String edtMovimientoCosto_Jsonclick ;
      private String edtMovimientoCostoTotal_Jsonclick ;
      private String GXt_char12 ;
      private DateTime Gx_date ;
      private DateTime AV10MovimientoFecha ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6ClinicaCodigo ;
      private String AV8TipoMICodigo ;
      private String A41ClinicaCodigo ;
      private String A114TipoMICodigo ;
      private String A30ArticuloCodigo ;
      private String AV7BodegaCodigo ;
      private String AV12MovimientoReferencia ;
      private String AV13MovimientoObs ;
      private String AV15ArticuloCodigo ;
      private String AV16ArticuloDescripcion ;
      private String AV14UsuarioCodigo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavBodegacodigo ;
      private GXCombobox dynavTipomicodigo ;
      private IDataStoreProvider pr_default ;
      private String[] H00342_A121BodegaCodigo ;
      private String[] H00342_A122BodegaDescripcion ;
      private String[] H00342_A41ClinicaCodigo ;
      private short[] H00342_A123BodegaEstado ;
      private String[] H00343_A114TipoMICodigo ;
      private String[] H00343_A115TipoMIDescripcion ;
      private String[] H00343_A41ClinicaCodigo ;
      private short[] H00343_A287TipoMIRestringe ;
      private short[] H00343_A118TipoMIEstado ;
      private String[] H00344_A30ArticuloCodigo ;
      private short[] H00344_A272MovimientoLinea ;
      private int[] H00344_A267MovimientoId ;
      private String[] H00344_A114TipoMICodigo ;
      private String[] H00344_A41ClinicaCodigo ;
      private decimal[] H00344_A274MovimientoCosto ;
      private decimal[] H00344_A273MovimientoCantidad ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV5Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class wp_registramovinv__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00342 ;
          prmH00342 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH00343 ;
          prmH00343 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH00344 ;
          prmH00344 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV9MovimientoId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00342", "SELECT [BodegaCodigo], [BodegaDescripcion], [ClinicaCodigo], [BodegaEstado] FROM [Bodega] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV6ClinicaCodigo) AND ([BodegaEstado] = 1) ORDER BY [BodegaDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00342,0,0,true,false )
             ,new CursorDef("H00343", "SELECT [TipoMICodigo], [TipoMIDescripcion], [ClinicaCodigo], [TipoMIRestringe], [TipoMIEstado] FROM [TipoMovInventario] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV6ClinicaCodigo) AND ([TipoMIRestringe] = 0) AND ([TipoMIEstado] = 1) ORDER BY [TipoMIDescripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00343,0,0,true,false )
             ,new CursorDef("H00344", "SELECT [ArticuloCodigo], [MovimientoLinea], [MovimientoId], [TipoMICodigo], [ClinicaCodigo], [MovimientoCosto], [MovimientoCantidad] FROM [MovimientoInvDetalle] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV6ClinicaCodigo and [TipoMICodigo] = @AV8TipoMICodigo and [MovimientoId] = @AV9MovimientoId ORDER BY [ClinicaCodigo], [TipoMICodigo], [MovimientoId], [MovimientoLinea] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00344,11,0,true,false )
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
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
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
