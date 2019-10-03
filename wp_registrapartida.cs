/*
               File: wp_registrapartida
        Description: Registra Partida Contable
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:9.13
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
   public class wp_registrapartida : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_registrapartida( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_registrapartida( IGxContext context )
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
         dynavTipoparcodigo = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vTIPOPARCODIGO") == 0 )
            {
               AV5ClinicaCodigo = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLVvTIPOPARCODIGO362( AV5ClinicaCodigo) ;
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
               nGXsfl_74_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_74_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_74_idx, sGXsfl_74_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               Gx_time = context.localUtil.Time( ) ;
               Gx_date = DateTimeUtil.Today( ) ;
               context.Gx_err = 0 ;
               dynavTipoparcodigo.Name = "vTIPOPARCODIGO" ;
               dynavTipoparcodigo.WebTags = "" ;
               AV7TipoParCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
               AV5ClinicaCodigo = GetNextPar( ) ;
               AV10PartidaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( AV7TipoParCodigo, AV5ClinicaCodigo, AV10PartidaId) ;
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
         PA362( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START362( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_registrapartida.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vTIPOPARCODIGO", StringUtil.RTrim( AV7TipoParCodigo));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV5ClinicaCodigo));
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
            WE362( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT362( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_registrapartida" ;
      }

      public override String GetPgmdesc( )
      {
         return "Registra Partida Contable" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_registrapartida.aspx")  ;
      }

      protected void WB360( )
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
            wb_table1_2_362( true) ;
         }
         else
         {
            wb_table1_2_362( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_362e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START362( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Registra Partida Contable", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP360( ) ;
      }

      protected void WS362( )
      {
         START362( ) ;
         EVT362( ) ;
      }

      protected void EVT362( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'OBTIENE PARTIDA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11362 */
                              E11362 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'VALIDA CUENTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12362 */
                              E12362 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'AGREGAR CUENTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E13362 */
                              E13362 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E14362 */
                              E14362 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'IMPRIMIR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E15362 */
                              E15362 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CONFIRMAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E16362 */
                              E16362 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ELIMINAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E17362 */
                              E17362 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'ELIMINAR'") == 0 ) )
                           {
                              nGXsfl_74_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_74_idx ;
                              edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_74_idx ;
                              edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_74_idx ;
                              edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_74_idx ;
                              edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_74_idx ;
                              edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_74_idx ;
                              edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_74_idx ;
                              edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_74_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A199TipoParCodigo = cgiGet( edtTipoParCodigo_Internalname) ;
                              A207PartidaId = (int)(context.localUtil.CToN( cgiGet( edtPartidaId_Internalname), ".", ",")) ;
                              A214PartidaLinea = (short)(context.localUtil.CToN( cgiGet( edtPartidaLinea_Internalname), ".", ",")) ;
                              A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
                              A194CtaContableNombre = cgiGet( edtCtaContableNombre_Internalname) ;
                              A215PartidaDebe = context.localUtil.CToN( cgiGet( edtPartidaDebe_Internalname), ".", ",") ;
                              A216PartidaHaber = context.localUtil.CToN( cgiGet( edtPartidaHaber_Internalname), ".", ",") ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E18362 */
                                    E18362 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E19362 */
                                    E19362 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Tipoparcodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTIPOPARCODIGO"), AV7TipoParCodigo) != 0 )
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
                                 else if ( StringUtil.StrCmp(sEvt, "'ELIMINAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E17362 */
                                    E17362 ();
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

      protected void WE362( )
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

      protected void PA362( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            dynavTipoparcodigo.Name = "vTIPOPARCODIGO" ;
            dynavTipoparcodigo.WebTags = "" ;
            GX_FocusControl = dynavTipoparcodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvTIPOPARCODIGO362( String AV5ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvTIPOPARCODIGO_data362( AV5ClinicaCodigo) ;
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

      protected void GXVvTIPOPARCODIGO_html362( String AV5ClinicaCodigo )
      {
         String gxdynajaxvalue ;
         GXDLVvTIPOPARCODIGO_data362( AV5ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynavTipoparcodigo.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynavTipoparcodigo.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavTipoparcodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV7TipoParCodigo)) )
            {
               AV7TipoParCodigo = dynavTipoparcodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
            }
         }
      }

      protected void GXDLVvTIPOPARCODIGO_data362( String AV5ClinicaCodigo )
      {
         /* Using cursor H00362 */
         pr_default.execute(0, new Object[] {AV5ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H00362_A199TipoParCodigo[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H00362_A200TipoParNombre[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_74_idx ,
                                       String sGXsfl_74_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_74_idx ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_74_idx ;
         edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_74_idx ;
         edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_74_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_74_idx ;
         edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_74_idx ;
         edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_74_idx ;
         edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_74_idx ;
         while ( nGXsfl_74_idx <= nRC_Grid1 )
         {
            sendrow_742( ) ;
            nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1)) ;
            sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_74_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_74_idx ;
            edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_74_idx ;
            edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_74_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_74_idx ;
            edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_74_idx ;
            edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_74_idx ;
            edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_74_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String AV7TipoParCodigo ,
                                        String AV5ClinicaCodigo ,
                                        int AV10PartidaId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF362( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF362( ) ;
         /* End function Refresh */
      }

      protected void RF362( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 74 ;
         nGXsfl_74_idx = 1 ;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_74_idx ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_74_idx ;
         edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_74_idx ;
         edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_74_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_74_idx ;
         edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_74_idx ;
         edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_74_idx ;
         edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_74_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_74_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_74_idx ;
            edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_74_idx ;
            edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_74_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_74_idx ;
            edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_74_idx ;
            edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_74_idx ;
            edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_74_idx ;
            /* Using cursor H00363 */
            pr_default.execute(1, new Object[] {AV5ClinicaCodigo, AV7TipoParCodigo, AV10PartidaId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A216PartidaHaber = H00363_A216PartidaHaber[0] ;
               A215PartidaDebe = H00363_A215PartidaDebe[0] ;
               A194CtaContableNombre = H00363_A194CtaContableNombre[0] ;
               A193CtaContableCodigo = H00363_A193CtaContableCodigo[0] ;
               A214PartidaLinea = H00363_A214PartidaLinea[0] ;
               A207PartidaId = H00363_A207PartidaId[0] ;
               A199TipoParCodigo = H00363_A199TipoParCodigo[0] ;
               A41ClinicaCodigo = H00363_A41ClinicaCodigo[0] ;
               A194CtaContableNombre = H00363_A194CtaContableNombre[0] ;
               /* Execute user event: E19362 */
               E19362 ();
               pr_default.readNext(1);
            }
            pr_default.close(1);
            wbEnd = 74 ;
            WB360( ) ;
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

      protected void STRUP360( )
      {
         /* Before Start, stand alone formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         edtavPartidaid_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPartidaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPartidaid_Enabled), 5, 0)));
         edtavPartidafecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPartidafecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPartidafecha_Enabled), 5, 0)));
         edtavPartidahora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPartidahora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPartidahora_Enabled), 5, 0)));
         edtavCtacontablenombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavCtacontablenombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavCtacontablenombre_Enabled), 5, 0)));
         edtavPartidadebet_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPartidadebet_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPartidadebet_Enabled), 5, 0)));
         edtavPartidahabert_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPartidahabert_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPartidahabert_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E18362 */
         E18362 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         GXVvTIPOPARCODIGO_html362( AV5ClinicaCodigo) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            dynavTipoparcodigo.Name = dynavTipoparcodigo_Internalname ;
            dynavTipoparcodigo.CurrentValue = cgiGet( dynavTipoparcodigo_Internalname) ;
            AV7TipoParCodigo = cgiGet( dynavTipoparcodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
            AV10PartidaId = (int)(context.localUtil.CToN( cgiGet( edtavPartidaid_Internalname), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
            AV8PartidaFecha = context.localUtil.CToD( cgiGet( edtavPartidafecha_Internalname), 2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PartidaFecha", context.localUtil.Format(AV8PartidaFecha, "99/99/99"));
            AV9PartidaHora = cgiGet( edtavPartidahora_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PartidaHora", AV9PartidaHora);
            AV16PartidaReferencia = cgiGet( edtavPartidareferencia_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PartidaReferencia", AV16PartidaReferencia);
            AV11PartidaObs = cgiGet( edtavPartidaobs_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PartidaObs", AV11PartidaObs);
            AV12CtaContableCodigo = cgiGet( edtavCtacontablecodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12CtaContableCodigo", AV12CtaContableCodigo);
            AV15CtaContableNombre = cgiGet( edtavCtacontablenombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15CtaContableNombre", AV15CtaContableNombre);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPartidadebe_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPartidadebe_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPARTIDADEBE");
               GX_FocusControl = edtavPartidadebe_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV13PartidaDebe = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PartidaDebe", StringUtil.LTrim( StringUtil.Str( AV13PartidaDebe, 17, 2)));
            }
            else
            {
               AV13PartidaDebe = context.localUtil.CToN( cgiGet( edtavPartidadebe_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PartidaDebe", StringUtil.LTrim( StringUtil.Str( AV13PartidaDebe, 17, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavPartidahaber_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavPartidahaber_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vPARTIDAHABER");
               GX_FocusControl = edtavPartidahaber_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14PartidaHaber = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PartidaHaber", StringUtil.LTrim( StringUtil.Str( AV14PartidaHaber, 17, 2)));
            }
            else
            {
               AV14PartidaHaber = context.localUtil.CToN( cgiGet( edtavPartidahaber_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PartidaHaber", StringUtil.LTrim( StringUtil.Str( AV14PartidaHaber, 17, 2)));
            }
            AV24PartidaDebeT = context.localUtil.CToN( cgiGet( edtavPartidadebet_Internalname), ".", ",") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PartidaDebeT", StringUtil.LTrim( StringUtil.Str( AV24PartidaDebeT, 17, 2)));
            AV25PartidaHaberT = context.localUtil.CToN( cgiGet( edtavPartidahabert_Internalname), ".", ",") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PartidaHaberT", StringUtil.LTrim( StringUtil.Str( AV25PartidaHaberT, 17, 2)));
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
         /* Execute user event: E18362 */
         E18362 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18362( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV6Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV6Parametros = GXt_SdtParametros4 ;
         AV5ClinicaCodigo = AV6Parametros.gxTpr_Pclinicacodigo ;
         AV21UsuarioCodigo = AV6Parametros.gxTpr_Pusuariocodigo ;
         bttButton4_Jsonclick = "confirm('¿Seguro de confirmar el registro de la partida contable?')" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton4_Internalname, "Jsonclick", bttButton4_Jsonclick);
      }

      protected void E11362( )
      {
         /* 'Obtiene Partida' Routine */
         if ( AV10PartidaId == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( AV7TipoParCodigo)) )
            {
               GX_msglist.addItem("Debe seleccionar un tipo de partida.");
            }
            else
            {
               GXt_int5 = AV10PartidaId ;
               new oobtienecorrelativopartida(context ).execute(  AV5ClinicaCodigo,  AV7TipoParCodigo, out  GXt_int5) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
               AV10PartidaId = GXt_int5 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
               AV8PartidaFecha = Gx_date ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PartidaFecha", context.localUtil.Format(AV8PartidaFecha, "99/99/99"));
               AV9PartidaHora = Gx_time ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PartidaHora", AV9PartidaHora);
            }
         }
      }

      protected void E12362( )
      {
         /* 'Valida Cuenta' Routine */
         new oobtienecuentacontable(context ).execute( ref  AV5ClinicaCodigo, ref  AV12CtaContableCodigo, ref  AV15CtaContableNombre, ref  AV17CtaContableNivel, ref  AV19CtaContableManual) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12CtaContableCodigo", AV12CtaContableCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15CtaContableNombre", AV15CtaContableNombre);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV15CtaContableNombre)) )
         {
            GX_msglist.addItem("Cuenta inválida.");
         }
         else
         {
            if ( AV19CtaContableManual == 0 )
            {
               GX_msglist.addItem("Cuenta contable no permite registros manuales.");
               GX_FocusControl = edtavCtacontablecodigo_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               if ( AV17CtaContableNivel < 5 )
               {
                  GX_msglist.addItem("Nivel de cuenta no permite registros contables");
                  GX_FocusControl = edtavCtacontablecodigo_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  GX_FocusControl = edtavPartidadebe_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
         }
      }

      protected void E13362( )
      {
         /* 'Agregar Cuenta' Routine */
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV15CtaContableNombre)) )
         {
            GX_msglist.addItem("Debe ingresar una cuenta contable válida.");
            GX_FocusControl = edtavCtacontablecodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            if ( (Convert.ToDecimal(0)==AV13PartidaDebe) && (Convert.ToDecimal(0)==AV14PartidaHaber) )
            {
               GX_msglist.addItem("Debe ingresar algún valor para la partida.");
            }
            else
            {
               if ( ( AV13PartidaDebe == Convert.ToDecimal( 0 )) && ( AV14PartidaHaber == Convert.ToDecimal( 0 )) )
               {
                  GX_msglist.addItem("Debe ingresar algún valor para la partida.");
               }
               else
               {
                  GXt_int6 = 1 ;
                  new oobtienepartidaestado(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  AV22PartidaEstado, ref  AV23PartidaMayorizada, ref  GXt_int6) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
                  if ( ( AV22PartidaEstado == 0 ) && ( AV23PartidaMayorizada == 0 ) )
                  {
                     GXt_int6 = 0 ;
                     GXt_int7 = 0 ;
                     new pregistrapartidaenc(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  AV8PartidaFecha, ref  AV9PartidaHora, ref  AV11PartidaObs, ref  GXt_int6, ref  AV16PartidaReferencia, ref  AV21UsuarioCodigo, ref  GXt_int7) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PartidaFecha", context.localUtil.Format(AV8PartidaFecha, "99/99/99"));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PartidaHora", AV9PartidaHora);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PartidaObs", AV11PartidaObs);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PartidaReferencia", AV16PartidaReferencia);
                     new pregistrapartidadet(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  AV13PartidaDebe, ref  AV14PartidaHaber, ref  AV12CtaContableCodigo) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PartidaDebe", StringUtil.LTrim( StringUtil.Str( AV13PartidaDebe, 17, 2)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PartidaHaber", StringUtil.LTrim( StringUtil.Str( AV14PartidaHaber, 17, 2)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12CtaContableCodigo", AV12CtaContableCodigo);
                     new oobtienepartidasaldo(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  AV24PartidaDebeT, ref  AV25PartidaHaberT) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PartidaDebeT", StringUtil.LTrim( StringUtil.Str( AV24PartidaDebeT, 17, 2)));
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PartidaHaberT", StringUtil.LTrim( StringUtil.Str( AV25PartidaHaberT, 17, 2)));
                     AV13PartidaDebe = 0 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PartidaDebe", StringUtil.LTrim( StringUtil.Str( AV13PartidaDebe, 17, 2)));
                     AV14PartidaHaber = 0 ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PartidaHaber", StringUtil.LTrim( StringUtil.Str( AV14PartidaHaber, 17, 2)));
                     AV15CtaContableNombre = "" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15CtaContableNombre", AV15CtaContableNombre);
                     AV19CtaContableManual = 0 ;
                     AV17CtaContableNivel = 0 ;
                     AV12CtaContableCodigo = "" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12CtaContableCodigo", AV12CtaContableCodigo);
                     GX_FocusControl = edtavCtacontablecodigo_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
            }
         }
      }

      protected void E14362( )
      {
         /* 'Regresar' Routine */
         GXt_int7 = 1 ;
         new oobtienepartidaestado(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  AV22PartidaEstado, ref  AV23PartidaMayorizada, ref  GXt_int7) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
         if ( ( AV22PartidaEstado == 1 ) && ( AV23PartidaMayorizada == 1 ) )
         {
            context.wjLoc = formatLink("wp_consultapartidas.aspx")  ;
         }
         else
         {
            GXt_int7 = 2 ;
            GXt_int6 = 2 ;
            new oobtienepartidaestado(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  GXt_int7, ref  AV23PartidaMayorizada, ref  GXt_int6) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
            context.wjLoc = formatLink("wp_consultapartidas.aspx")  ;
         }
      }

      protected void E15362( )
      {
         /* 'Imprimir' Routine */
         GXt_int7 = 1 ;
         new oobtienepartidaestado(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  AV22PartidaEstado, ref  AV23PartidaMayorizada, ref  GXt_int7) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
         if ( ( AV22PartidaEstado == 1 ) && ( AV23PartidaMayorizada == 1 ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV5ClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV7TipoParCodigo)) + "," + UrlEncode("" +AV10PartidaId) ;
            context.wjLoc = formatLink("arpartidacontable.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
         }
         else
         {
            GX_msglist.addItem("Partida contable no ha sido registrada. No puede generar la impresión.");
         }
      }

      protected void E16362( )
      {
         /* 'Confirmar' Routine */
         new oobtienepartidasaldo(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  AV24PartidaDebeT, ref  AV25PartidaHaberT) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PartidaDebeT", StringUtil.LTrim( StringUtil.Str( AV24PartidaDebeT, 17, 2)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PartidaHaberT", StringUtil.LTrim( StringUtil.Str( AV25PartidaHaberT, 17, 2)));
         if ( AV24PartidaDebeT == AV25PartidaHaberT )
         {
            GXt_int7 = 1 ;
            new oobtienepartidaestado(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  AV22PartidaEstado, ref  AV23PartidaMayorizada, ref  GXt_int7) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
            if ( ( AV22PartidaEstado == 0 ) && ( AV23PartidaMayorizada == 0 ) )
            {
               GXt_int7 = 1 ;
               GXt_int6 = 1 ;
               new pmayorizapartida(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  GXt_int7, ref  GXt_int6, ref  AV21UsuarioCodigo) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
               GX_msglist.addItem("Partida contable registrada exitosamente.");
            }
            else
            {
               GX_msglist.addItem("Partida contable ya fue registrada. Revise.");
            }
         }
         else
         {
            GX_msglist.addItem("Partida contable no está cuadrada, no puede registrarse. Revise.");
         }
      }

      protected void E17362( )
      {
         /* 'Eliminar' Routine */
         GXt_int8 = 1 ;
         new oobtienepartidaestado(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  AV22PartidaEstado, ref  AV23PartidaMayorizada, ref  GXt_int8) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
         if ( ( AV22PartidaEstado == 0 ) && ( AV23PartidaMayorizada == 0 ) )
         {
            new peliminacuentapartida(context ).execute( ref  AV5ClinicaCodigo, ref  AV7TipoParCodigo, ref  AV10PartidaId, ref  A214PartidaLinea) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
         }
         else
         {
            GX_msglist.addItem("Partida contable ya fue registrada, no puede modificarse. Revise.");
         }
      }

      private void E19362( )
      {
         /* Load Routine */
         sendrow_742( ) ;
      }

      protected void wb_table1_2_362( bool wbgen )
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
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_10_362( true) ;
         }
         else
         {
            wb_table2_10_362( false) ;
         }
         return  ;
      }

      protected void wb_table2_10_362e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table3_33_362( true) ;
         }
         else
         {
            wb_table3_33_362( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_362e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table4_46_362( true) ;
         }
         else
         {
            wb_table4_46_362( false) ;
         }
         return  ;
      }

      protected void wb_table4_46_362e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:129px\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"74\">") ;
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
               context.SendWebValue( "Tipo_Partida") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Partida") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Línea") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cta_Contable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Debe") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Haber") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A199TipoParCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PartidaId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A193CtaContableCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A194CtaContableNombre));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A215PartidaDebe, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A216PartidaHaber, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 74 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_74_idx-1) ;
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:16px\">") ;
            wb_table5_85_362( true) ;
         }
         else
         {
            wb_table5_85_362( false) ;
         }
         return  ;
      }

      protected void wb_table5_85_362e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton4_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 3, 0)+","+"null"+");", "Confirmar", bttButton4_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, 1, 1, "standard", "E\\'CONFIRMAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton5_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 3, 0)+","+"null"+");", "Imprimir", bttButton5_Jsonclick, 5, "Imprimir", "", StyleString, ClassString, 1, 1, "standard", "E\\'IMPRIMIR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton7_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 3, 0)+","+"null"+");", "Regresar", bttButton7_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_362e( true) ;
         }
         else
         {
            wb_table1_2_362e( false) ;
         }
      }

      protected void wb_table5_85_362( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock21_Internalname, "Totales de Partida Contable", "", "", lblTextblock21_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24PartidaDebeT", StringUtil.LTrim( StringUtil.Str( AV24PartidaDebeT, 17, 2)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPartidadebet_Internalname, StringUtil.LTrim( StringUtil.NToC( AV24PartidaDebeT, 17, 2, ".", "")), ((edtavPartidadebet_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV24PartidaDebeT, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV24PartidaDebeT, "ZZZZZZZZZZZZZ9.99")), "", "", "", "", "", edtavPartidadebet_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPartidadebet_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25PartidaHaberT", StringUtil.LTrim( StringUtil.Str( AV25PartidaHaberT, 17, 2)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPartidahabert_Internalname, StringUtil.LTrim( StringUtil.NToC( AV25PartidaHaberT, 17, 2, ".", "")), ((edtavPartidahabert_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV25PartidaHaberT, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV25PartidaHaberT, "ZZZZZZZZZZZZZ9.99")), "", "", "", "", "", edtavPartidahabert_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPartidahabert_Enabled, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_85_362e( true) ;
         }
         else
         {
            wb_table5_85_362e( false) ;
         }
      }

      protected void wb_table4_46_362( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock19_Internalname, "Cuenta Contable", "", "", lblTextblock19_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock18_Internalname, "Nombre", "", "", lblTextblock18_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock17_Internalname, "Debe", "", "", lblTextblock17_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock16_Internalname, "Haber", "", "", lblTextblock16_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12CtaContableCodigo", AV12CtaContableCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_74_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavCtacontablecodigo_Internalname, StringUtil.RTrim( AV12CtaContableCodigo), StringUtil.RTrim( context.localUtil.Format( AV12CtaContableCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(60);\"", "", "", "", "", edtavCtacontablecodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registrapartida.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, context.GetImagePath( "44bc25ef-9fb8-46cb-b15c-cd83e64c472e", "", "Fantastic"), "", "", "", "Fantastic", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 3, 0)+","+"null"+");", ">|", bttButton2_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'VALIDA CUENTA\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15CtaContableNombre", AV15CtaContableNombre);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavCtacontablenombre_Internalname, StringUtil.RTrim( AV15CtaContableNombre), StringUtil.RTrim( context.localUtil.Format( AV15CtaContableNombre, "")), "", "", "", "", "", edtavCtacontablenombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtavCtacontablenombre_Enabled, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PartidaDebe", StringUtil.LTrim( StringUtil.Str( AV13PartidaDebe, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_74_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPartidadebe_Internalname, StringUtil.LTrim( StringUtil.NToC( AV13PartidaDebe, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV13PartidaDebe, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV13PartidaDebe, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(67);\"", "", "", "", "", edtavPartidadebe_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PartidaHaber", StringUtil.LTrim( StringUtil.Str( AV14PartidaHaber, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_74_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPartidahaber_Internalname, StringUtil.LTrim( StringUtil.NToC( AV14PartidaHaber, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV14PartidaHaber, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV14PartidaHaber, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(69);\"", "", "", "", "", edtavPartidahaber_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 3, 0)+","+"null"+");", ">|", bttButton3_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'AGREGAR CUENTA\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_46_362e( true) ;
         }
         else
         {
            wb_table4_46_362e( false) ;
         }
      }

      protected void wb_table3_33_362( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, "Referencia", "", "", lblTextblock11_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PartidaReferencia", AV16PartidaReferencia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_74_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPartidareferencia_Internalname, StringUtil.RTrim( AV16PartidaReferencia), StringUtil.RTrim( context.localUtil.Format( AV16PartidaReferencia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(38);\"", "", "", "", "", edtavPartidareferencia_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock20_Internalname, "Observaciones", "", "", lblTextblock20_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PartidaObs", AV11PartidaObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_74_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_html_textarea( context, edtavPartidaobs_Internalname, StringUtil.RTrim( AV11PartidaObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_362e( true) ;
         }
         else
         {
            wb_table3_33_362e( false) ;
         }
      }

      protected void wb_table2_10_362( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock14_Internalname, "Tipo Partida", "", "", lblTextblock14_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7TipoParCodigo", AV7TipoParCodigo);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'" + sGXsfl_74_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavTipoparcodigo, dynavTipoparcodigo_Internalname, AV7TipoParCodigo, 1, dynavTipoparcodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 70, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(15);\"", "", true, "HLP_wp_registrapartida.htm");
            dynavTipoparcodigo.CurrentValue = AV7TipoParCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavTipoparcodigo_Internalname, "Values", (String)(dynavTipoparcodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(74), 3, 0)+","+"null"+");", ">|", bttButton1_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'OBTIENE PARTIDA\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, "Partida Id", "", "", lblTextblock13_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PartidaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10PartidaId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPartidaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10PartidaId), 9, 0, ".", "")), ((edtavPartidaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10PartidaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10PartidaId), "ZZZZZZZZ9")), "", "", "", "", "", edtavPartidaid_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPartidaid_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, "Fecha / Hora", "", "", lblTextblock12_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PartidaFecha", context.localUtil.Format(AV8PartidaFecha, "99/99/99"));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavPartidafecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPartidafecha_Internalname, context.localUtil.Format(AV8PartidaFecha, "99/99/99"), context.localUtil.Format( AV8PartidaFecha, "99/99/99"), "", "", "", "", "", edtavPartidafecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPartidafecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registrapartida.htm");
            GxWebStd.gx_bitmap( context, edtavPartidafecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtavPartidafecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_registrapartida.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PartidaHora", AV9PartidaHora);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPartidahora_Internalname, StringUtil.RTrim( AV9PartidaHora), StringUtil.RTrim( context.localUtil.Format( AV9PartidaHora, "XXXXXXXX")), "", "", "", "", "", edtavPartidahora_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPartidahora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registrapartida.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_362e( true) ;
         }
         else
         {
            wb_table2_10_362e( false) ;
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
         PA362( ) ;
         WS362( ) ;
         WE362( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1581034");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("wp_registrapartida.js", "?1581035");
         /* End function include_jscripts */
      }

      protected void sendrow_742( )
      {
         WB360( ) ;
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
            if ( ((int)(nGXsfl_74_idx) % (2)) == 0 )
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
            context.WriteHtmlText( " gxrow=\""+sGXsfl_74_idx+"\">") ;
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
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoParCodigo_Internalname,StringUtil.RTrim( A199TipoParCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoParCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PartidaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A207PartidaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)74,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaLinea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A214PartidaLinea), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A214PartidaLinea), "ZZZ9"),(String)"","E\\'ELIMINAR\\'."+sGXsfl_74_idx,(String)"",(String)"",(String)"",(String)edtPartidaLinea_Jsonclick,(short)5,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)74,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCtaContableCodigo_Internalname,StringUtil.RTrim( A193CtaContableCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCtaContableCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)74,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCtaContableNombre_Internalname,StringUtil.RTrim( A194CtaContableNombre),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCtaContableNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)80,(short)0,(short)0,(short)74,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaDebe_Internalname,StringUtil.LTrim( StringUtil.NToC( A215PartidaDebe, 17, 2, ".", "")),context.localUtil.Format( A215PartidaDebe, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaDebe_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)74,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaHaber_Internalname,StringUtil.LTrim( StringUtil.NToC( A216PartidaHaber, 17, 2, ".", "")),context.localUtil.Format( A216PartidaHaber, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaHaber_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)74,(short)1,(short)1,(bool)true,(String)"right"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_74_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_74_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_74_idx+1)) ;
         sGXsfl_74_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_74_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_74_idx ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_74_idx ;
         edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_74_idx ;
         edtPartidaLinea_Internalname = "PARTIDALINEA_"+sGXsfl_74_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_74_idx ;
         edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_74_idx ;
         edtPartidaDebe_Internalname = "PARTIDADEBE_"+sGXsfl_74_idx ;
         edtPartidaHaber_Internalname = "PARTIDAHABER_"+sGXsfl_74_idx ;
         /* End function sendrow_742 */
      }

      protected void init_default_properties( )
      {
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         dynavTipoparcodigo_Internalname = "vTIPOPARCODIGO" ;
         bttButton1_Internalname = "BUTTON1" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         edtavPartidaid_Internalname = "vPARTIDAID" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         edtavPartidafecha_Internalname = "vPARTIDAFECHA" ;
         edtavPartidahora_Internalname = "vPARTIDAHORA" ;
         tblTable2_Internalname = "TABLE2" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         edtavPartidareferencia_Internalname = "vPARTIDAREFERENCIA" ;
         lblTextblock20_Internalname = "TEXTBLOCK20" ;
         edtavPartidaobs_Internalname = "vPARTIDAOBS" ;
         tblTable3_Internalname = "TABLE3" ;
         lblTextblock19_Internalname = "TEXTBLOCK19" ;
         lblTextblock18_Internalname = "TEXTBLOCK18" ;
         lblTextblock17_Internalname = "TEXTBLOCK17" ;
         lblTextblock16_Internalname = "TEXTBLOCK16" ;
         edtavCtacontablecodigo_Internalname = "vCTACONTABLECODIGO" ;
         imgImage1_Internalname = "IMAGE1" ;
         bttButton2_Internalname = "BUTTON2" ;
         edtavCtacontablenombre_Internalname = "vCTACONTABLENOMBRE" ;
         edtavPartidadebe_Internalname = "vPARTIDADEBE" ;
         edtavPartidahaber_Internalname = "vPARTIDAHABER" ;
         bttButton3_Internalname = "BUTTON3" ;
         tblTable4_Internalname = "TABLE4" ;
         lblTextblock21_Internalname = "TEXTBLOCK21" ;
         edtavPartidadebet_Internalname = "vPARTIDADEBET" ;
         edtavPartidahabert_Internalname = "vPARTIDAHABERT" ;
         tblTable5_Internalname = "TABLE5" ;
         bttButton4_Internalname = "BUTTON4" ;
         bttButton5_Internalname = "BUTTON5" ;
         bttButton7_Internalname = "BUTTON7" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtPartidaHaber_Jsonclick = "" ;
         edtPartidaDebe_Jsonclick = "" ;
         edtCtaContableNombre_Jsonclick = "" ;
         edtCtaContableCodigo_Jsonclick = "" ;
         edtPartidaLinea_Jsonclick = "" ;
         edtPartidaId_Jsonclick = "" ;
         edtTipoParCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavPartidahora_Jsonclick = "" ;
         edtavPartidahora_Enabled = 0 ;
         edtavPartidafecha_Jsonclick = "" ;
         edtavPartidafecha_Enabled = 0 ;
         edtavPartidaid_Jsonclick = "" ;
         edtavPartidaid_Enabled = 0 ;
         dynavTipoparcodigo_Jsonclick = "" ;
         edtavPartidareferencia_Jsonclick = "" ;
         edtavPartidahaber_Jsonclick = "" ;
         edtavPartidadebe_Jsonclick = "" ;
         edtavCtacontablenombre_Jsonclick = "" ;
         edtavCtacontablenombre_Enabled = 0 ;
         edtavCtacontablecodigo_Jsonclick = "" ;
         edtavPartidahabert_Jsonclick = "" ;
         edtavPartidahabert_Enabled = 0 ;
         edtavPartidadebet_Jsonclick = "" ;
         edtavPartidadebet_Enabled = 0 ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Registra Partida Contable" ;
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
         AV5ClinicaCodigo = "" ;
         Gx_time = "" ;
         Gx_date = DateTime.MinValue ;
         AV7TipoParCodigo = "" ;
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
         edtTipoParCodigo_Internalname = "" ;
         edtPartidaId_Internalname = "" ;
         edtPartidaLinea_Internalname = "" ;
         edtCtaContableCodigo_Internalname = "" ;
         edtCtaContableNombre_Internalname = "" ;
         edtPartidaDebe_Internalname = "" ;
         edtPartidaHaber_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A199TipoParCodigo = "" ;
         A193CtaContableCodigo = "" ;
         A194CtaContableNombre = "" ;
         GXKey = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         H00362_A199TipoParCodigo = new String[] {""} ;
         H00362_A200TipoParNombre = new String[] {""} ;
         H00362_A41ClinicaCodigo = new String[] {""} ;
         H00362_A203TipoParEstado = new short[1] ;
         Grid1Container = new GXWebGrid( context);
         H00363_A216PartidaHaber = new decimal[1] ;
         H00363_A215PartidaDebe = new decimal[1] ;
         H00363_A194CtaContableNombre = new String[] {""} ;
         H00363_A193CtaContableCodigo = new String[] {""} ;
         H00363_A214PartidaLinea = new short[1] ;
         H00363_A207PartidaId = new int[1] ;
         H00363_A199TipoParCodigo = new String[] {""} ;
         H00363_A41ClinicaCodigo = new String[] {""} ;
         AV8PartidaFecha = DateTime.MinValue ;
         AV9PartidaHora = "" ;
         AV16PartidaReferencia = "" ;
         AV11PartidaObs = "" ;
         AV12CtaContableCodigo = "" ;
         AV15CtaContableNombre = "" ;
         AV6Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         AV21UsuarioCodigo = "" ;
         bttButton4_Jsonclick = "" ;
         GXEncryptionTmp = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char12 = "" ;
         TempTags = "" ;
         bttButton5_Jsonclick = "" ;
         bttButton7_Jsonclick = "" ;
         lblTextblock21_Jsonclick = "" ;
         lblTextblock19_Jsonclick = "" ;
         lblTextblock18_Jsonclick = "" ;
         lblTextblock17_Jsonclick = "" ;
         lblTextblock16_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         lblTextblock20_Jsonclick = "" ;
         lblTextblock14_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         lblTextblock13_Jsonclick = "" ;
         lblTextblock12_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char13 = "" ;
         ROClassString = "" ;
         GXt_char14 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_registrapartida__default(),
            new Object[][] {
                new Object[] {
               H00362_A199TipoParCodigo, H00362_A200TipoParNombre, H00362_A41ClinicaCodigo, H00362_A203TipoParEstado
               }
               , new Object[] {
               H00363_A216PartidaHaber, H00363_A215PartidaDebe, H00363_A194CtaContableNombre, H00363_A193CtaContableCodigo, H00363_A214PartidaLinea, H00363_A207PartidaId, H00363_A199TipoParCodigo, H00363_A41ClinicaCodigo
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
      private short nGXsfl_74_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short A214PartidaLinea ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV17CtaContableNivel ;
      private short AV19CtaContableManual ;
      private short AV22PartidaEstado ;
      private short AV23PartidaMayorizada ;
      private short GXt_int7 ;
      private short GXt_int6 ;
      private short GXt_int8 ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV10PartidaId ;
      private int A207PartidaId ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int edtavPartidaid_Enabled ;
      private int edtavPartidafecha_Enabled ;
      private int edtavPartidahora_Enabled ;
      private int edtavCtacontablenombre_Enabled ;
      private int edtavPartidadebet_Enabled ;
      private int edtavPartidahabert_Enabled ;
      private int GXt_int5 ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal A215PartidaDebe ;
      private decimal A216PartidaHaber ;
      private decimal AV13PartidaDebe ;
      private decimal AV14PartidaHaber ;
      private decimal AV24PartidaDebeT ;
      private decimal AV25PartidaHaberT ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_74_idx="0001" ;
      private String Gx_time ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtClinicaCodigo_Internalname ;
      private String edtTipoParCodigo_Internalname ;
      private String edtPartidaId_Internalname ;
      private String edtPartidaLinea_Internalname ;
      private String edtCtaContableCodigo_Internalname ;
      private String edtCtaContableNombre_Internalname ;
      private String edtPartidaDebe_Internalname ;
      private String edtPartidaHaber_Internalname ;
      private String GXKey ;
      private String dynavTipoparcodigo_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavPartidaid_Internalname ;
      private String edtavPartidafecha_Internalname ;
      private String edtavPartidahora_Internalname ;
      private String edtavCtacontablenombre_Internalname ;
      private String edtavPartidadebet_Internalname ;
      private String edtavPartidahabert_Internalname ;
      private String AV9PartidaHora ;
      private String edtavPartidareferencia_Internalname ;
      private String edtavPartidaobs_Internalname ;
      private String edtavCtacontablecodigo_Internalname ;
      private String edtavPartidadebe_Internalname ;
      private String edtavPartidahaber_Internalname ;
      private String bttButton4_Jsonclick ;
      private String bttButton4_Internalname ;
      private String GXEncryptionTmp ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String TempTags ;
      private String bttButton5_Internalname ;
      private String bttButton5_Jsonclick ;
      private String bttButton7_Internalname ;
      private String bttButton7_Jsonclick ;
      private String tblTable5_Internalname ;
      private String lblTextblock21_Internalname ;
      private String lblTextblock21_Jsonclick ;
      private String edtavPartidadebet_Jsonclick ;
      private String edtavPartidahabert_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblock19_Internalname ;
      private String lblTextblock19_Jsonclick ;
      private String lblTextblock18_Internalname ;
      private String lblTextblock18_Jsonclick ;
      private String lblTextblock17_Internalname ;
      private String lblTextblock17_Jsonclick ;
      private String lblTextblock16_Internalname ;
      private String lblTextblock16_Jsonclick ;
      private String edtavCtacontablecodigo_Jsonclick ;
      private String imgImage1_Internalname ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String edtavCtacontablenombre_Jsonclick ;
      private String edtavPartidadebe_Jsonclick ;
      private String edtavPartidahaber_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtavPartidareferencia_Jsonclick ;
      private String lblTextblock20_Internalname ;
      private String lblTextblock20_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String dynavTipoparcodigo_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String edtavPartidaid_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String edtavPartidafecha_Jsonclick ;
      private String edtavPartidahora_Jsonclick ;
      private String GXt_char13 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtTipoParCodigo_Jsonclick ;
      private String edtPartidaId_Jsonclick ;
      private String edtPartidaLinea_Jsonclick ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String edtCtaContableNombre_Jsonclick ;
      private String edtPartidaDebe_Jsonclick ;
      private String edtPartidaHaber_Jsonclick ;
      private String GXt_char14 ;
      private DateTime Gx_date ;
      private DateTime AV8PartidaFecha ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5ClinicaCodigo ;
      private String AV7TipoParCodigo ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String A193CtaContableCodigo ;
      private String A194CtaContableNombre ;
      private String AV16PartidaReferencia ;
      private String AV11PartidaObs ;
      private String AV12CtaContableCodigo ;
      private String AV15CtaContableNombre ;
      private String AV21UsuarioCodigo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavTipoparcodigo ;
      private IDataStoreProvider pr_default ;
      private String[] H00362_A199TipoParCodigo ;
      private String[] H00362_A200TipoParNombre ;
      private String[] H00362_A41ClinicaCodigo ;
      private short[] H00362_A203TipoParEstado ;
      private decimal[] H00363_A216PartidaHaber ;
      private decimal[] H00363_A215PartidaDebe ;
      private String[] H00363_A194CtaContableNombre ;
      private String[] H00363_A193CtaContableCodigo ;
      private short[] H00363_A214PartidaLinea ;
      private int[] H00363_A207PartidaId ;
      private String[] H00363_A199TipoParCodigo ;
      private String[] H00363_A41ClinicaCodigo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV6Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class wp_registrapartida__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00362 ;
          prmH00362 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH00363 ;
          prmH00363 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7TipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV10PartidaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00362", "SELECT [TipoParCodigo], [TipoParNombre], [ClinicaCodigo], [TipoParEstado] FROM [TipoPartida] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV5ClinicaCodigo) AND ([TipoParEstado] = 1) ORDER BY [TipoParNombre] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00362,0,0,true,false )
             ,new CursorDef("H00363", "SELECT T1.[PartidaHaber], T1.[PartidaDebe], T2.[CtaContableNombre], T1.[CtaContableCodigo], T1.[PartidaLinea], T1.[PartidaId], T1.[TipoParCodigo], T1.[ClinicaCodigo] FROM ([PartidaDet] T1 WITH (NOLOCK) INNER JOIN [CuentaContable] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[CtaContableCodigo] = T1.[CtaContableCodigo]) WHERE T1.[ClinicaCodigo] = @AV5ClinicaCodigo and T1.[TipoParCodigo] = @AV7TipoParCodigo and T1.[PartidaId] = @AV10PartidaId ORDER BY T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId], T1.[PartidaLinea] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00363,11,0,true,false )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
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
                stmt.SetParameter(3, (int)parms[2]);
                break;
       }
    }

 }

}
