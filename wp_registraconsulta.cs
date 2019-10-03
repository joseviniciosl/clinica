/*
               File: wp_registraconsulta
        Description: Registra Consulta de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:43.32
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
   public class wp_registraconsulta : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_registraconsulta( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_registraconsulta( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_PacienteId ,
                           ref int aP1_ConsultaId )
      {
         this.AV8PacienteId = aP0_PacienteId;
         this.AV7ConsultaId = aP1_ConsultaId;
         executePrivate();
         aP0_PacienteId=this.AV8PacienteId;
         aP1_ConsultaId=this.AV7ConsultaId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavPacientegenero = new GXCombobox();
         cmbavConsultatipo = new GXCombobox();
         cmbavAsegcodigo = new GXCombobox();
         cmbavMedicocodigo = new GXCombobox();
         cmbavCie10codigo = new GXCombobox();
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
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp ;
            }
            if ( ! entryPointCalled )
            {
               AV8PacienteId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV7ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
               }
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
         PA1J2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1J2( ) ;
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
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV8PacienteId) + "," + UrlEncode("" +AV7ConsultaId) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_registraconsulta.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         if ( ! ( WebComp_Webcomp1 == null ) )
         {
            WebComp_Webcomp1.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE1J2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1J2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_registraconsulta" ;
      }

      public override String GetPgmdesc( )
      {
         return "Registra Consulta de Pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV8PacienteId) + "," + UrlEncode("" +AV7ConsultaId) ;
         return formatLink("wp_registraconsulta.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void WB1J0( )
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
            wb_table1_2_1J2( true) ;
         }
         else
         {
            wb_table1_2_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1J2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Registra Consulta de Pacientes", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            OldWebcomp1 = cgiGet( "W0120") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Webcomp1_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWebcomp1)) )
            {
               WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", OldWebcomp1, new Object[] {context} );
               WebComp_Webcomp1.ComponentInit();
               WebComp_Webcomp1.Name = "OldWebcomp1";
               WebComp_Webcomp1_Component = OldWebcomp1 ;
               WebComp_Webcomp1.componentrestorestate("W0120", "");
            }
         }
         wbErr = false ;
         STRUP1J0( ) ;
      }

      protected void WS1J2( )
      {
         START1J2( ) ;
         EVT1J2( ) ;
      }

      protected void EVT1J2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111J2 */
                              E111J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121J2 */
                              E121J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'FINALIZAR CONSULTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E131J2 */
                              E131J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CARGOS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E141J2 */
                              E141J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'RECETA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E151J2 */
                              E151J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'SIGNOS VITALES'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E161J2 */
                              E161J2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E171J2 */
                              E171J2 ();
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
                              /* No code required for Cancel button. It is implemented as the Reset button. */
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4) ;
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                        nCmpId = (short)(NumberUtil.Val( sEvtType, ".")) ;
                        if ( nCmpId == 120 )
                        {
                           OldWebcomp1 = cgiGet( "W0120") ;
                           if ( ( StringUtil.Len( OldWebcomp1) == 0 ) || ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 ) )
                           {
                              WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", OldWebcomp1, new Object[] {context} );
                              WebComp_Webcomp1.ComponentInit();
                              WebComp_Webcomp1.Name = "OldWebcomp1";
                              WebComp_Webcomp1_Component = OldWebcomp1 ;
                           }
                           if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
                           {
                              WebComp_Webcomp1.componentprocess("W0120", "", sEvt);
                           }
                           WebComp_Webcomp1_Component = OldWebcomp1 ;
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE1J2( )
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

      protected void PA1J2( )
      {
         if ( nDonePA == 0 )
         {
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
            if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               if ( nGotPars == 0 )
               {
                  entryPointCalled = false ;
                  gxfirstwebparm = GetNextPar( ) ;
                  if ( ! entryPointCalled )
                  {
                     AV8PacienteId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
                     if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
                     {
                        AV7ConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
                     }
                  }
               }
            }
            cmbavPacientegenero.Name = "vPACIENTEGENERO" ;
            cmbavPacientegenero.WebTags = "" ;
            cmbavPacientegenero.addItem("M", "Masculino", 0);
            cmbavPacientegenero.addItem("F", "Femenino", 0);
            if ( ( cmbavPacientegenero.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV17PacienteGenero)) )
            {
               AV17PacienteGenero = cmbavPacientegenero.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PacienteGenero", AV17PacienteGenero);
            }
            cmbavConsultatipo.Name = "vCONSULTATIPO" ;
            cmbavConsultatipo.WebTags = "" ;
            cmbavConsultatipo.addItem("1", "Consulta en clínica", 0);
            cmbavConsultatipo.addItem("2", "Consulta telefónica", 0);
            cmbavConsultatipo.addItem("3", "En hospital", 0);
            cmbavConsultatipo.addItem("4", "A domicilio", 0);
            if ( ( cmbavConsultatipo.ItemCount > 0 ) && (0==AV19ConsultaTipo) )
            {
               AV19ConsultaTipo = (short)(NumberUtil.Val( cmbavConsultatipo.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ConsultaTipo", StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0));
            }
            cmbavAsegcodigo.Name = "vASEGCODIGO" ;
            cmbavAsegcodigo.WebTags = "" ;
            if ( ( cmbavAsegcodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV21AsegCodigo)) )
            {
               AV21AsegCodigo = cmbavAsegcodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
            }
            cmbavMedicocodigo.Name = "vMEDICOCODIGO" ;
            cmbavMedicocodigo.WebTags = "" ;
            if ( ( cmbavMedicocodigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV26MedicoCodigo)) )
            {
               AV26MedicoCodigo = cmbavMedicocodigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
            }
            cmbavCie10codigo.Name = "vCIE10CODIGO" ;
            cmbavCie10codigo.WebTags = "" ;
            if ( ( cmbavCie10codigo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV24Cie10Codigo)) )
            {
               AV24Cie10Codigo = cmbavCie10codigo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
            }
            GX_FocusControl = cmbavConsultatipo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF1J2( ) ;
         /* End function Refresh */
      }

      protected void RF1J2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
               {
                  WebComp_Webcomp1.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E171J2 */
            E171J2 ();
            WB1J0( ) ;
         }
      }

      protected void STRUP1J0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         edtavConsultaid_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConsultaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConsultaid_Enabled), 5, 0)));
         edtavConsultafecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConsultafecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConsultafecha_Enabled), 5, 0)));
         edtavConsultahora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConsultahora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConsultahora_Enabled), 5, 0)));
         edtavPacientenombre1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacientenombre1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacientenombre1_Enabled), 5, 0)));
         edtavPacientenombre2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacientenombre2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacientenombre2_Enabled), 5, 0)));
         edtavPacienteapellido1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacienteapellido1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacienteapellido1_Enabled), 5, 0)));
         edtavPacienteapellido2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacienteapellido2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacienteapellido2_Enabled), 5, 0)));
         edtavPacienteapellido3_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacienteapellido3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacienteapellido3_Enabled), 5, 0)));
         cmbavPacientegenero.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPacientegenero_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavPacientegenero.Enabled), 5, 0)));
         edtavPacientenacimiento_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacientenacimiento_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacientenacimiento_Enabled), 5, 0)));
         edtavConsultaedad_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConsultaedad_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConsultaedad_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111J2 */
         E111J2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV9ConsultaFecha = context.localUtil.CToD( cgiGet( edtavConsultafecha_Internalname), 2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ConsultaFecha", context.localUtil.Format(AV9ConsultaFecha, "99/99/99"));
            AV10ConsultaHora = cgiGet( edtavConsultahora_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConsultaHora", AV10ConsultaHora);
            AV11PacienteNombre1 = cgiGet( edtavPacientenombre1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteNombre1", AV11PacienteNombre1);
            AV12PacienteNombre2 = cgiGet( edtavPacientenombre2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12PacienteNombre2", AV12PacienteNombre2);
            AV13PacienteApellido1 = cgiGet( edtavPacienteapellido1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteApellido1", AV13PacienteApellido1);
            AV14PacienteApellido2 = cgiGet( edtavPacienteapellido2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PacienteApellido2", AV14PacienteApellido2);
            AV15PacienteApellido3 = cgiGet( edtavPacienteapellido3_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PacienteApellido3", AV15PacienteApellido3);
            AV16PacienteNacimiento = context.localUtil.CToD( cgiGet( edtavPacientenacimiento_Internalname), 2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PacienteNacimiento", context.localUtil.Format(AV16PacienteNacimiento, "99/99/99"));
            AV18ConsultaEdad = (short)(context.localUtil.CToN( cgiGet( edtavConsultaedad_Internalname), ".", ",")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ConsultaEdad), 4, 0)));
            cmbavPacientegenero.CurrentValue = cgiGet( cmbavPacientegenero_Internalname) ;
            AV17PacienteGenero = cgiGet( cmbavPacientegenero_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PacienteGenero", AV17PacienteGenero);
            cmbavConsultatipo.CurrentValue = cgiGet( cmbavConsultatipo_Internalname) ;
            AV19ConsultaTipo = (short)(NumberUtil.Val( cgiGet( cmbavConsultatipo_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ConsultaTipo", StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0));
            cmbavAsegcodigo.CurrentValue = cgiGet( cmbavAsegcodigo_Internalname) ;
            AV21AsegCodigo = cgiGet( cmbavAsegcodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
            AV20ConsultaPoliza = cgiGet( edtavConsultapoliza_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ConsultaPoliza", AV20ConsultaPoliza);
            cmbavMedicocodigo.CurrentValue = cgiGet( cmbavMedicocodigo_Internalname) ;
            AV26MedicoCodigo = cgiGet( cmbavMedicocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
            cmbavCie10codigo.CurrentValue = cgiGet( cmbavCie10codigo_Internalname) ;
            AV24Cie10Codigo = cgiGet( cmbavCie10codigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
            AV22ConsultaObs = cgiGet( edtavConsultaobs_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ConsultaObs", AV22ConsultaObs);
            /* Read saved values. */
            OldWebcomp1 = cgiGet( "W0120") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Webcomp1_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWebcomp1)) )
            {
               WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", OldWebcomp1, new Object[] {context} );
               WebComp_Webcomp1.ComponentInit();
               WebComp_Webcomp1.Name = "OldWebcomp1";
               WebComp_Webcomp1_Component = OldWebcomp1 ;
               WebComp_Webcomp1.componentrestorestate("W0120", "");
            }
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
         /* Execute user event: E111J2 */
         E111J2 ();
         if (returnInSub) return;
      }

      protected void E111J2( )
      {
         /* Start Routine */
         bttButton5_Jsonclick = "confirm('Seguro de finalizar la consulta?')" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton5_Internalname, "Jsonclick", bttButton5_Jsonclick);
         bttButton6_Jsonclick = "confirm('Seguro de retornar? La consulta se cancelará.')" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton6_Internalname, "Jsonclick", bttButton6_Jsonclick);
         GXt_SdtParametros3 = AV5Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV5Parametros = GXt_SdtParametros3 ;
         AV6ClinicaCodigo = AV5Parametros.gxTpr_Pclinicacodigo ;
         new pobtieneinfopaciente(context ).execute( ref  AV6ClinicaCodigo, ref  AV8PacienteId, ref  AV11PacienteNombre1, ref  AV12PacienteNombre2, ref  AV13PacienteApellido1, ref  AV14PacienteApellido2, ref  AV15PacienteApellido3, ref  AV17PacienteGenero, ref  AV16PacienteNacimiento, ref  AV18ConsultaEdad) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteNombre1", AV11PacienteNombre1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12PacienteNombre2", AV12PacienteNombre2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteApellido1", AV13PacienteApellido1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PacienteApellido2", AV14PacienteApellido2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PacienteApellido3", AV15PacienteApellido3);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PacienteGenero", AV17PacienteGenero);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PacienteNacimiento", context.localUtil.Format(AV16PacienteNacimiento, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ConsultaEdad), 4, 0)));
         AV9ConsultaFecha = Gx_date ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ConsultaFecha", context.localUtil.Format(AV9ConsultaFecha, "99/99/99"));
         AV10ConsultaHora = Gx_time ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConsultaHora", AV10ConsultaHora);
         /* Using cursor H001J2 */
         pr_default.execute(0, new Object[] {AV6ClinicaCodigo});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A41ClinicaCodigo = H001J2_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A83AsegNombre = H001J2_A83AsegNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A83AsegNombre", A83AsegNombre);
            A82AsegCodigo = H001J2_A82AsegCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A82AsegCodigo", A82AsegCodigo);
            cmbavAsegcodigo.addItem(A82AsegCodigo, A83AsegNombre, 0);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         AV21AsegCodigo = "000" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
         /* Using cursor H001J3 */
         pr_default.execute(1, new Object[] {AV6ClinicaCodigo});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A41ClinicaCodigo = H001J3_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A51Cie10Descripcion = H001J3_A51Cie10Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51Cie10Descripcion", A51Cie10Descripcion);
            A50Cie10Codigo = H001J3_A50Cie10Codigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50Cie10Codigo", A50Cie10Codigo);
            cmbavCie10codigo.addItem(A50Cie10Codigo, A51Cie10Descripcion, 0);
            pr_default.readNext(1);
         }
         pr_default.close(1);
         AV24Cie10Codigo = "|00" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
         /* Using cursor H001J4 */
         pr_default.execute(2, new Object[] {AV6ClinicaCodigo});
         while ( (pr_default.getStatus(2) != 101) )
         {
            A41ClinicaCodigo = H001J4_A41ClinicaCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
            A20MedicoNombre = H001J4_A20MedicoNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20MedicoNombre", A20MedicoNombre);
            A19MedicoCodigo = H001J4_A19MedicoCodigo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
            cmbavMedicocodigo.addItem(A19MedicoCodigo, A20MedicoNombre, 0);
            pr_default.readNext(2);
         }
         pr_default.close(2);
         AV26MedicoCodigo = "000" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
         GXt_int4 = 1 ;
         new pregistraconsulta(context ).execute( ref  AV6ClinicaCodigo, ref  AV7ConsultaId, ref  AV9ConsultaFecha, ref  AV10ConsultaHora, ref  AV8PacienteId, ref  AV19ConsultaTipo, ref  AV21AsegCodigo, ref  AV22ConsultaObs, ref  AV24Cie10Codigo, ref  AV18ConsultaEdad, ref  AV20ConsultaPoliza, ref  GXt_int4, ref  AV26MedicoCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ConsultaFecha", context.localUtil.Format(AV9ConsultaFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConsultaHora", AV10ConsultaHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ConsultaTipo", StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ConsultaObs", AV22ConsultaObs);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ConsultaEdad), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ConsultaPoliza", AV20ConsultaPoliza);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
      }

      protected void E121J2( )
      {
         /* 'Regresar' Routine */
         GXt_int5 = 4 ;
         new pregistraconsulta(context ).execute( ref  AV6ClinicaCodigo, ref  AV7ConsultaId, ref  AV9ConsultaFecha, ref  AV10ConsultaHora, ref  AV8PacienteId, ref  AV19ConsultaTipo, ref  AV21AsegCodigo, ref  AV22ConsultaObs, ref  AV24Cie10Codigo, ref  AV18ConsultaEdad, ref  AV20ConsultaPoliza, ref  GXt_int5, ref  AV26MedicoCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ConsultaFecha", context.localUtil.Format(AV9ConsultaFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConsultaHora", AV10ConsultaHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ConsultaTipo", StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ConsultaObs", AV22ConsultaObs);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ConsultaEdad), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ConsultaPoliza", AV20ConsultaPoliza);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
         context.wjLoc = formatLink("wp_paciente.aspx")  ;
      }

      protected void E131J2( )
      {
         /* 'Finalizar Consulta' Routine */
         GXt_int5 = 2 ;
         new pregistraconsulta(context ).execute( ref  AV6ClinicaCodigo, ref  AV7ConsultaId, ref  AV9ConsultaFecha, ref  AV10ConsultaHora, ref  AV8PacienteId, ref  AV19ConsultaTipo, ref  AV21AsegCodigo, ref  AV22ConsultaObs, ref  AV24Cie10Codigo, ref  AV18ConsultaEdad, ref  AV20ConsultaPoliza, ref  GXt_int5, ref  AV26MedicoCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ConsultaFecha", context.localUtil.Format(AV9ConsultaFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConsultaHora", AV10ConsultaHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ConsultaTipo", StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ConsultaObs", AV22ConsultaObs);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ConsultaEdad), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ConsultaPoliza", AV20ConsultaPoliza);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
         context.wjLoc = formatLink("wp_paciente.aspx")  ;
      }

      protected void E141J2( )
      {
         /* 'Cargos' Routine */
         GXt_int5 = 1 ;
         new pregistraconsulta(context ).execute( ref  AV6ClinicaCodigo, ref  AV7ConsultaId, ref  AV9ConsultaFecha, ref  AV10ConsultaHora, ref  AV8PacienteId, ref  AV19ConsultaTipo, ref  AV21AsegCodigo, ref  AV22ConsultaObs, ref  AV24Cie10Codigo, ref  AV18ConsultaEdad, ref  AV20ConsultaPoliza, ref  GXt_int5, ref  AV26MedicoCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ConsultaFecha", context.localUtil.Format(AV9ConsultaFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConsultaHora", AV10ConsultaHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ConsultaTipo", StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ConsultaObs", AV22ConsultaObs);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ConsultaEdad), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ConsultaPoliza", AV20ConsultaPoliza);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
         /* Object Property */
         if ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "wc_Cargos") != 0 )
         {
            WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "wc_cargos", new Object[] {context} );
            WebComp_Webcomp1.ComponentInit();
            WebComp_Webcomp1.Name = "wc_Cargos";
            WebComp_Webcomp1_Component = "wc_Cargos" ;
         }
         if ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 )
         {
            WebComp_Webcomp1.setjustcreated();
         }
         if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
         {
            WebComp_Webcomp1.componentprepare(new Object[] {(String)"W0120",(String)"",(String)AV6ClinicaCodigo,(int)AV7ConsultaId});
            WebComp_Webcomp1.componentbind(new Object[] {(String)"",(String)"vCONSULTAID"});
         }
      }

      protected void E151J2( )
      {
         /* 'Receta' Routine */
         GXt_int5 = 1 ;
         new pregistraconsulta(context ).execute( ref  AV6ClinicaCodigo, ref  AV7ConsultaId, ref  AV9ConsultaFecha, ref  AV10ConsultaHora, ref  AV8PacienteId, ref  AV19ConsultaTipo, ref  AV21AsegCodigo, ref  AV22ConsultaObs, ref  AV24Cie10Codigo, ref  AV18ConsultaEdad, ref  AV20ConsultaPoliza, ref  GXt_int5, ref  AV26MedicoCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ConsultaFecha", context.localUtil.Format(AV9ConsultaFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConsultaHora", AV10ConsultaHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ConsultaTipo", StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ConsultaObs", AV22ConsultaObs);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ConsultaEdad), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ConsultaPoliza", AV20ConsultaPoliza);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
         /* Object Property */
         if ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "wc_Recetas") != 0 )
         {
            WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "wc_recetas", new Object[] {context} );
            WebComp_Webcomp1.ComponentInit();
            WebComp_Webcomp1.Name = "wc_Recetas";
            WebComp_Webcomp1_Component = "wc_Recetas" ;
         }
         if ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 )
         {
            WebComp_Webcomp1.setjustcreated();
         }
         if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
         {
            WebComp_Webcomp1.componentprepare(new Object[] {(String)"W0120",(String)"",(String)AV6ClinicaCodigo,(int)AV7ConsultaId});
            WebComp_Webcomp1.componentbind(new Object[] {(String)"",(String)"vCONSULTAID"});
         }
      }

      protected void E161J2( )
      {
         /* 'Signos Vitales' Routine */
         GXt_int5 = 1 ;
         new pregistraconsulta(context ).execute( ref  AV6ClinicaCodigo, ref  AV7ConsultaId, ref  AV9ConsultaFecha, ref  AV10ConsultaHora, ref  AV8PacienteId, ref  AV19ConsultaTipo, ref  AV21AsegCodigo, ref  AV22ConsultaObs, ref  AV24Cie10Codigo, ref  AV18ConsultaEdad, ref  AV20ConsultaPoliza, ref  GXt_int5, ref  AV26MedicoCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ConsultaFecha", context.localUtil.Format(AV9ConsultaFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConsultaHora", AV10ConsultaHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ConsultaTipo", StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ConsultaObs", AV22ConsultaObs);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ConsultaEdad), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ConsultaPoliza", AV20ConsultaPoliza);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
         /* Object Property */
         if ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "wc_SignosVitales") != 0 )
         {
            WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "wc_signosvitales", new Object[] {context} );
            WebComp_Webcomp1.ComponentInit();
            WebComp_Webcomp1.Name = "wc_SignosVitales";
            WebComp_Webcomp1_Component = "wc_SignosVitales" ;
         }
         if ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 )
         {
            WebComp_Webcomp1.setjustcreated();
         }
         if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
         {
            WebComp_Webcomp1.componentprepare(new Object[] {(String)"W0120",(String)"",(String)AV6ClinicaCodigo,(int)AV7ConsultaId});
            WebComp_Webcomp1.componentbind(new Object[] {(String)"",(String)"vCONSULTAID"});
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E171J2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_1J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:29px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:16.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Registro de Consulta", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_11_1J2( true) ;
         }
         else
         {
            wb_table2_11_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "W0120"+"", StringUtil.RTrim( WebComp_Webcomp1_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpW0120"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0120"+"");
               }
               WebComp_Webcomp1.componentdraw();
               if ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1J2e( true) ;
         }
         else
         {
            wb_table1_2_1J2e( false) ;
         }
      }

      protected void wb_table2_11_1J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table3_14_1J2( true) ;
         }
         else
         {
            wb_table3_14_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table3_14_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "&nbsp;") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table4_30_1J2( true) ;
         }
         else
         {
            wb_table4_30_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table4_30_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table5_72_1J2( true) ;
         }
         else
         {
            wb_table5_72_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table5_72_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:39px\">") ;
            wb_table6_88_1J2( true) ;
         }
         else
         {
            wb_table6_88_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table6_88_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+";height:45px\">") ;
            wb_table7_96_1J2( true) ;
         }
         else
         {
            wb_table7_96_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table7_96_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table8_104_1J2( true) ;
         }
         else
         {
            wb_table8_104_1J2( false) ;
         }
         return  ;
      }

      protected void wb_table8_104_1J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 112,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Signos Vitales", bttButton1_Jsonclick, 5, "Signos Vitales", "", StyleString, ClassString, 1, 1, "standard", "E\\'SIGNOS VITALES\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "", "Receta", bttButton3_Jsonclick, 5, "Receta", "", StyleString, ClassString, 1, 1, "standard", "E\\'RECETA\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton4_Internalname, "", "Cargos", bttButton4_Jsonclick, 5, "Cargos", "", StyleString, ClassString, 1, 1, "standard", "E\\'CARGOS\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton5_Internalname, "", "Finalizar Consulta", bttButton5_Jsonclick, 5, "Finalizar Consulta", "", StyleString, ClassString, 1, 1, "standard", "E\\'FINALIZAR CONSULTA\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton6_Internalname, "", "Cancelar", bttButton6_Jsonclick, 5, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 117,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "Expediente médico", bttButton2_Jsonclick, 7, "Expediente médico", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e181j1_client"+"'", TempTags, "", 2, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_1J2e( true) ;
         }
         else
         {
            wb_table2_11_1J2e( false) ;
         }
      }

      protected void wb_table8_104_1J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable6_Internalname, tblTable6_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock17_Internalname, "Observaciones", "", "", lblTextblock17_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ConsultaObs", AV22ConsultaObs);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_html_textarea( context, edtavConsultaobs_Internalname, StringUtil.RTrim( AV22ConsultaObs), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(109);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_104_1J2e( true) ;
         }
         else
         {
            wb_table8_104_1J2e( false) ;
         }
      }

      protected void wb_table7_96_1J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable7_Internalname, tblTable7_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock18_Internalname, "Diagnóstico CIE-10", "", "", lblTextblock18_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24Cie10Codigo", AV24Cie10Codigo);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCie10codigo, cmbavCie10codigo_Internalname, AV24Cie10Codigo, 1, cmbavCie10codigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 10, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(101);\"", "", true, "HLP_wp_registraconsulta.htm");
            cmbavCie10codigo.CurrentValue = AV24Cie10Codigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCie10codigo_Internalname, "Values", (String)(cmbavCie10codigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_96_1J2e( true) ;
         }
         else
         {
            wb_table7_96_1J2e( false) ;
         }
      }

      protected void wb_table6_88_1J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable8_Internalname, tblTable8_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock19_Internalname, "Médico Tratante", "", "", lblTextblock19_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26MedicoCodigo", AV26MedicoCodigo);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavMedicocodigo, cmbavMedicocodigo_Internalname, AV26MedicoCodigo, 1, cmbavMedicocodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 10, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(93);\"", "", true, "HLP_wp_registraconsulta.htm");
            cmbavMedicocodigo.CurrentValue = AV26MedicoCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavMedicocodigo_Internalname, "Values", (String)(cmbavMedicocodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_88_1J2e( true) ;
         }
         else
         {
            wb_table6_88_1J2e( false) ;
         }
      }

      protected void wb_table5_72_1J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "Tipo Consulta", "", "", lblTextblock8_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ConsultaTipo", StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavConsultatipo, cmbavConsultatipo_Internalname, StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0), 1, cmbavConsultatipo_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(77);\"", "", true, "HLP_wp_registraconsulta.htm");
            cmbavConsultatipo.CurrentValue = StringUtil.Str( (decimal)(AV19ConsultaTipo), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavConsultatipo_Internalname, "Values", (String)(cmbavConsultatipo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "Aseguradora", "", "", lblTextblock7_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21AsegCodigo", AV21AsegCodigo);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavAsegcodigo, cmbavAsegcodigo_Internalname, AV21AsegCodigo, 1, cmbavAsegcodigo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 10, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(81);\"", "", true, "HLP_wp_registraconsulta.htm");
            cmbavAsegcodigo.CurrentValue = AV21AsegCodigo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavAsegcodigo_Internalname, "Values", (String)(cmbavAsegcodigo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Póliza / Certificado", "", "", lblTextblock6_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ConsultaPoliza", AV20ConsultaPoliza);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavConsultapoliza_Internalname, StringUtil.RTrim( AV20ConsultaPoliza), StringUtil.RTrim( context.localUtil.Format( AV20ConsultaPoliza, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(85);\"", "", "", "", "", edtavConsultapoliza_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_72_1J2e( true) ;
         }
         else
         {
            wb_table5_72_1J2e( false) ;
         }
      }

      protected void wb_table4_30_1J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Paciente Id", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8PacienteId), 9, 0, ".", "")), context.localUtil.Format( (decimal)(AV8PacienteId), "ZZZZZZZZ9"), "", "", "", "", "", edtavPacienteid_Jsonclick, 0, ClassString, StyleString, "", 1, 0, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock16_Internalname, "Primer Nombre", "", "", lblTextblock16_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteNombre1", AV11PacienteNombre1);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacientenombre1_Internalname, StringUtil.RTrim( AV11PacienteNombre1), StringUtil.RTrim( context.localUtil.Format( AV11PacienteNombre1, "")), "", "", "", "", "", edtavPacientenombre1_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacientenombre1_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock15_Internalname, "Segundo Nombre", "", "", lblTextblock15_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12PacienteNombre2", AV12PacienteNombre2);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacientenombre2_Internalname, StringUtil.RTrim( AV12PacienteNombre2), StringUtil.RTrim( context.localUtil.Format( AV12PacienteNombre2, "")), "", "", "", "", "", edtavPacientenombre2_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacientenombre2_Enabled, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, "Primer Apellido", "", "", lblTextblock12_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteApellido1", AV13PacienteApellido1);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteapellido1_Internalname, StringUtil.RTrim( AV13PacienteApellido1), StringUtil.RTrim( context.localUtil.Format( AV13PacienteApellido1, "")), "", "", "", "", "", edtavPacienteapellido1_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacienteapellido1_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, "Segundo Nombre", "", "", lblTextblock13_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14PacienteApellido2", AV14PacienteApellido2);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteapellido2_Internalname, StringUtil.RTrim( AV14PacienteApellido2), StringUtil.RTrim( context.localUtil.Format( AV14PacienteApellido2, "")), "", "", "", "", "", edtavPacienteapellido2_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacienteapellido2_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock14_Internalname, "Apellido de Casada", "", "", lblTextblock14_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15PacienteApellido3", AV15PacienteApellido3);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteapellido3_Internalname, StringUtil.RTrim( AV15PacienteApellido3), StringUtil.RTrim( context.localUtil.Format( AV15PacienteApellido3, "")), "", "", "", "", "", edtavPacienteapellido3_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacienteapellido3_Enabled, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, "Fecha Nac.", "", "", lblTextblock11_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16PacienteNacimiento", context.localUtil.Format(AV16PacienteNacimiento, "99/99/99"));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavPacientenacimiento_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPacientenacimiento_Internalname, context.localUtil.Format(AV16PacienteNacimiento, "99/99/99"), context.localUtil.Format( AV16PacienteNacimiento, "99/99/99"), "", "", "", "", "", edtavPacientenacimiento_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacientenacimiento_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registraconsulta.htm");
            GxWebStd.gx_bitmap( context, edtavPacientenacimiento_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtavPacientenacimiento_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, "Edad", "", "", lblTextblock10_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ConsultaEdad", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18ConsultaEdad), 4, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavConsultaedad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18ConsultaEdad), 4, 0, ".", "")), ((edtavConsultaedad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18ConsultaEdad), "ZZZ9")) : context.localUtil.Format( (decimal)(AV18ConsultaEdad), "ZZZ9")), "", "", "", "", "", edtavConsultaedad_Jsonclick, 0, ClassString, StyleString, "", 1, edtavConsultaedad_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, "Genero", "", "", lblTextblock9_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17PacienteGenero", AV17PacienteGenero);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavPacientegenero, cmbavPacientegenero_Internalname, AV17PacienteGenero, 1, cmbavPacientegenero_Jsonclick, 0, "", "svchar", "", 1, cmbavPacientegenero.Enabled, 0, 0, 1, "chr", 0, "", StyleString, ClassString, "", "", true, "HLP_wp_registraconsulta.htm");
            cmbavPacientegenero.CurrentValue = AV17PacienteGenero ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPacientegenero_Internalname, "Values", (String)(cmbavPacientegenero.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_30_1J2e( true) ;
         }
         else
         {
            wb_table4_30_1J2e( false) ;
         }
      }

      protected void wb_table3_14_1J2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Consulta Id", "", "", lblTextblock2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavConsultaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ConsultaId), 9, 0, ".", "")), ((edtavConsultaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7ConsultaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7ConsultaId), "ZZZZZZZZ9")), "", "", "", "", "", edtavConsultaid_Jsonclick, 0, ClassString, StyleString, "", 1, edtavConsultaid_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Fecha", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9ConsultaFecha", context.localUtil.Format(AV9ConsultaFecha, "99/99/99"));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavConsultafecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavConsultafecha_Internalname, context.localUtil.Format(AV9ConsultaFecha, "99/99/99"), context.localUtil.Format( AV9ConsultaFecha, "99/99/99"), "", "", "", "", "", edtavConsultafecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtavConsultafecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_registraconsulta.htm");
            GxWebStd.gx_bitmap( context, edtavConsultafecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtavConsultafecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Hora", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10ConsultaHora", AV10ConsultaHora);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavConsultahora_Internalname, StringUtil.RTrim( AV10ConsultaHora), StringUtil.RTrim( context.localUtil.Format( AV10ConsultaHora, "XXXXXXXX")), "", "", "", "", "", edtavConsultahora_Jsonclick, 0, ClassString, StyleString, "", 1, edtavConsultahora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_wp_registraconsulta.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_14_1J2e( true) ;
         }
         else
         {
            wb_table3_14_1J2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8PacienteId = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PacienteId), 9, 0)));
         AV7ConsultaId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
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
         PA1J2( ) ;
         WS1J2( ) ;
         WE1J2( ) ;
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
         if ( ! ( WebComp_Webcomp1 == null ) )
         {
            if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
            {
               WebComp_Webcomp1.componentthemes();
            }
         }
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1574459");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("wp_registraconsulta.js", "?1574459");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavConsultaid_Internalname = "vCONSULTAID" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavConsultafecha_Internalname = "vCONSULTAFECHA" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtavConsultahora_Internalname = "vCONSULTAHORA" ;
         tblTable3_Internalname = "TABLE3" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavPacienteid_Internalname = "vPACIENTEID" ;
         lblTextblock16_Internalname = "TEXTBLOCK16" ;
         edtavPacientenombre1_Internalname = "vPACIENTENOMBRE1" ;
         lblTextblock15_Internalname = "TEXTBLOCK15" ;
         edtavPacientenombre2_Internalname = "vPACIENTENOMBRE2" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         edtavPacienteapellido1_Internalname = "vPACIENTEAPELLIDO1" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         edtavPacienteapellido2_Internalname = "vPACIENTEAPELLIDO2" ;
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         edtavPacienteapellido3_Internalname = "vPACIENTEAPELLIDO3" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         edtavPacientenacimiento_Internalname = "vPACIENTENACIMIENTO" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtavConsultaedad_Internalname = "vCONSULTAEDAD" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         cmbavPacientegenero_Internalname = "vPACIENTEGENERO" ;
         tblTable4_Internalname = "TABLE4" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         cmbavConsultatipo_Internalname = "vCONSULTATIPO" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         cmbavAsegcodigo_Internalname = "vASEGCODIGO" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavConsultapoliza_Internalname = "vCONSULTAPOLIZA" ;
         tblTable5_Internalname = "TABLE5" ;
         lblTextblock19_Internalname = "TEXTBLOCK19" ;
         cmbavMedicocodigo_Internalname = "vMEDICOCODIGO" ;
         tblTable8_Internalname = "TABLE8" ;
         lblTextblock18_Internalname = "TEXTBLOCK18" ;
         cmbavCie10codigo_Internalname = "vCIE10CODIGO" ;
         tblTable7_Internalname = "TABLE7" ;
         lblTextblock17_Internalname = "TEXTBLOCK17" ;
         edtavConsultaobs_Internalname = "vCONSULTAOBS" ;
         tblTable6_Internalname = "TABLE6" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttButton4_Internalname = "BUTTON4" ;
         bttButton5_Internalname = "BUTTON5" ;
         bttButton6_Internalname = "BUTTON6" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable2_Internalname = "TABLE2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavConsultahora_Jsonclick = "" ;
         edtavConsultahora_Enabled = 0 ;
         edtavConsultafecha_Jsonclick = "" ;
         edtavConsultafecha_Enabled = 0 ;
         edtavConsultaid_Jsonclick = "" ;
         edtavConsultaid_Enabled = 0 ;
         cmbavPacientegenero_Jsonclick = "" ;
         cmbavPacientegenero.Enabled = 0 ;
         edtavConsultaedad_Jsonclick = "" ;
         edtavConsultaedad_Enabled = 0 ;
         edtavPacientenacimiento_Jsonclick = "" ;
         edtavPacientenacimiento_Enabled = 0 ;
         edtavPacienteapellido3_Jsonclick = "" ;
         edtavPacienteapellido3_Enabled = 0 ;
         edtavPacienteapellido2_Jsonclick = "" ;
         edtavPacienteapellido2_Enabled = 0 ;
         edtavPacienteapellido1_Jsonclick = "" ;
         edtavPacienteapellido1_Enabled = 0 ;
         edtavPacientenombre2_Jsonclick = "" ;
         edtavPacientenombre2_Enabled = 0 ;
         edtavPacientenombre1_Jsonclick = "" ;
         edtavPacientenombre1_Enabled = 0 ;
         edtavPacienteid_Jsonclick = "" ;
         edtavConsultapoliza_Jsonclick = "" ;
         cmbavAsegcodigo_Jsonclick = "" ;
         cmbavConsultatipo_Jsonclick = "" ;
         cmbavMedicocodigo_Jsonclick = "" ;
         cmbavCie10codigo_Jsonclick = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Registra Consulta de Pacientes" ;
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
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         OldWebcomp1 = "" ;
         WebComp_Webcomp1_Component = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GXDecQS = "" ;
         AV17PacienteGenero = "" ;
         AV21AsegCodigo = "" ;
         AV26MedicoCodigo = "" ;
         AV24Cie10Codigo = "" ;
         Gx_time = "" ;
         Gx_date = DateTime.MinValue ;
         AV9ConsultaFecha = DateTime.MinValue ;
         AV10ConsultaHora = "" ;
         AV11PacienteNombre1 = "" ;
         AV12PacienteNombre2 = "" ;
         AV13PacienteApellido1 = "" ;
         AV14PacienteApellido2 = "" ;
         AV15PacienteApellido3 = "" ;
         AV16PacienteNacimiento = DateTime.MinValue ;
         AV20ConsultaPoliza = "" ;
         AV22ConsultaObs = "" ;
         bttButton5_Jsonclick = "" ;
         bttButton6_Jsonclick = "" ;
         AV5Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         AV6ClinicaCodigo = "" ;
         scmdbuf = "" ;
         H001J2_A41ClinicaCodigo = new String[] {""} ;
         H001J2_A83AsegNombre = new String[] {""} ;
         H001J2_A82AsegCodigo = new String[] {""} ;
         A41ClinicaCodigo = "" ;
         A83AsegNombre = "" ;
         A82AsegCodigo = "" ;
         H001J3_A41ClinicaCodigo = new String[] {""} ;
         H001J3_A51Cie10Descripcion = new String[] {""} ;
         H001J3_A50Cie10Codigo = new String[] {""} ;
         A51Cie10Descripcion = "" ;
         A50Cie10Codigo = "" ;
         H001J4_A41ClinicaCodigo = new String[] {""} ;
         H001J4_A20MedicoNombre = new String[] {""} ;
         H001J4_A19MedicoCodigo = new String[] {""} ;
         A20MedicoNombre = "" ;
         A19MedicoCodigo = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         GXt_char1 = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         lblTextblock17_Jsonclick = "" ;
         lblTextblock18_Jsonclick = "" ;
         lblTextblock19_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock16_Jsonclick = "" ;
         lblTextblock15_Jsonclick = "" ;
         lblTextblock12_Jsonclick = "" ;
         lblTextblock13_Jsonclick = "" ;
         lblTextblock14_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         lblTextblock9_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         GXt_char6 = "" ;
         GXt_char2 = "" ;
         lblTextblock4_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_registraconsulta__default(),
            new Object[][] {
                new Object[] {
               H001J2_A41ClinicaCodigo, H001J2_A83AsegNombre, H001J2_A82AsegCodigo
               }
               , new Object[] {
               H001J3_A41ClinicaCodigo, H001J3_A51Cie10Descripcion, H001J3_A50Cie10Codigo
               }
               , new Object[] {
               H001J4_A41ClinicaCodigo, H001J4_A20MedicoNombre, H001J4_A19MedicoCodigo
               }
            }
         );
         WebComp_Webcomp1 = new GeneXus.Http.GXNullWebComponent();
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short AV19ConsultaTipo ;
      private short AV18ConsultaEdad ;
      private short GXt_int4 ;
      private short GXt_int5 ;
      private short nGXWrapped ;
      private int AV8PacienteId ;
      private int AV7ConsultaId ;
      private int wcpOAV8PacienteId ;
      private int wcpOAV7ConsultaId ;
      private int edtavConsultaid_Enabled ;
      private int edtavConsultafecha_Enabled ;
      private int edtavConsultahora_Enabled ;
      private int edtavPacientenombre1_Enabled ;
      private int edtavPacientenombre2_Enabled ;
      private int edtavPacienteapellido1_Enabled ;
      private int edtavPacienteapellido2_Enabled ;
      private int edtavPacienteapellido3_Enabled ;
      private int edtavPacientenacimiento_Enabled ;
      private int edtavConsultaedad_Enabled ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String OldWebcomp1 ;
      private String WebComp_Webcomp1_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXDecQS ;
      private String cmbavConsultatipo_Internalname ;
      private String Gx_time ;
      private String edtavConsultaid_Internalname ;
      private String edtavConsultafecha_Internalname ;
      private String edtavConsultahora_Internalname ;
      private String edtavPacientenombre1_Internalname ;
      private String edtavPacientenombre2_Internalname ;
      private String edtavPacienteapellido1_Internalname ;
      private String edtavPacienteapellido2_Internalname ;
      private String edtavPacienteapellido3_Internalname ;
      private String cmbavPacientegenero_Internalname ;
      private String edtavPacientenacimiento_Internalname ;
      private String edtavConsultaedad_Internalname ;
      private String AV10ConsultaHora ;
      private String cmbavAsegcodigo_Internalname ;
      private String edtavConsultapoliza_Internalname ;
      private String cmbavMedicocodigo_Internalname ;
      private String cmbavCie10codigo_Internalname ;
      private String edtavConsultaobs_Internalname ;
      private String bttButton5_Jsonclick ;
      private String bttButton5_Internalname ;
      private String bttButton6_Jsonclick ;
      private String bttButton6_Internalname ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String GXt_char1 ;
      private String tblTable2_Internalname ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String tblTable6_Internalname ;
      private String lblTextblock17_Internalname ;
      private String lblTextblock17_Jsonclick ;
      private String tblTable7_Internalname ;
      private String lblTextblock18_Internalname ;
      private String lblTextblock18_Jsonclick ;
      private String cmbavCie10codigo_Jsonclick ;
      private String tblTable8_Internalname ;
      private String lblTextblock19_Internalname ;
      private String lblTextblock19_Jsonclick ;
      private String cmbavMedicocodigo_Jsonclick ;
      private String tblTable5_Internalname ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String cmbavConsultatipo_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String cmbavAsegcodigo_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavConsultapoliza_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavPacienteid_Internalname ;
      private String edtavPacienteid_Jsonclick ;
      private String lblTextblock16_Internalname ;
      private String lblTextblock16_Jsonclick ;
      private String edtavPacientenombre1_Jsonclick ;
      private String lblTextblock15_Internalname ;
      private String lblTextblock15_Jsonclick ;
      private String edtavPacientenombre2_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String edtavPacienteapellido1_Jsonclick ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String edtavPacienteapellido2_Jsonclick ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String edtavPacienteapellido3_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtavPacientenacimiento_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtavConsultaedad_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String cmbavPacientegenero_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavConsultaid_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String GXt_char6 ;
      private String edtavConsultafecha_Jsonclick ;
      private String GXt_char2 ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtavConsultahora_Jsonclick ;
      private DateTime Gx_date ;
      private DateTime AV9ConsultaFecha ;
      private DateTime AV16PacienteNacimiento ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV17PacienteGenero ;
      private String AV21AsegCodigo ;
      private String AV26MedicoCodigo ;
      private String AV24Cie10Codigo ;
      private String AV11PacienteNombre1 ;
      private String AV12PacienteNombre2 ;
      private String AV13PacienteApellido1 ;
      private String AV14PacienteApellido2 ;
      private String AV15PacienteApellido3 ;
      private String AV20ConsultaPoliza ;
      private String AV22ConsultaObs ;
      private String AV6ClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A83AsegNombre ;
      private String A82AsegCodigo ;
      private String A51Cie10Descripcion ;
      private String A50Cie10Codigo ;
      private String A20MedicoNombre ;
      private String A19MedicoCodigo ;
      private GXWebComponent WebComp_Webcomp1 ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private int aP0_PacienteId ;
      private int aP1_ConsultaId ;
      private GXCombobox cmbavPacientegenero ;
      private GXCombobox cmbavConsultatipo ;
      private GXCombobox cmbavAsegcodigo ;
      private GXCombobox cmbavMedicocodigo ;
      private GXCombobox cmbavCie10codigo ;
      private IDataStoreProvider pr_default ;
      private String[] H001J2_A41ClinicaCodigo ;
      private String[] H001J2_A83AsegNombre ;
      private String[] H001J2_A82AsegCodigo ;
      private String[] H001J3_A41ClinicaCodigo ;
      private String[] H001J3_A51Cie10Descripcion ;
      private String[] H001J3_A50Cie10Codigo ;
      private String[] H001J4_A41ClinicaCodigo ;
      private String[] H001J4_A20MedicoNombre ;
      private String[] H001J4_A19MedicoCodigo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV5Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

   public class wp_registraconsulta__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001J2 ;
          prmH001J2 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH001J3 ;
          prmH001J3 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH001J4 ;
          prmH001J4 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001J2", "SELECT [ClinicaCodigo], [AsegNombre], [AsegCodigo] FROM [Aseguradora] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV6ClinicaCodigo ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001J2,100,0,false,false )
             ,new CursorDef("H001J3", "SELECT [ClinicaCodigo], [Cie10Descripcion], [Cie10Codigo] FROM [Cie10] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV6ClinicaCodigo ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001J3,100,0,false,false )
             ,new CursorDef("H001J4", "SELECT [ClinicaCodigo], [MedicoNombre], [MedicoCodigo] FROM [Medico] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV6ClinicaCodigo ORDER BY [ClinicaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001J4,100,0,false,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                break;
       }
    }

 }

}
