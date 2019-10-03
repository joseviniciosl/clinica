/*
               File: wp_consultapartidas
        Description: Consulta de Partidas Contables
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:7.11
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
   public class wp_consultapartidas : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_consultapartidas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_consultapartidas( IGxContext context )
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
         cmbPartidaMayorizada = new GXCombobox();
         cmbPartidaEstado = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               Gx_date = DateTimeUtil.Today( ) ;
               context.Gx_err = 0 ;
               GXCCtl = "PARTIDAMAYORIZADA_" + sGXsfl_24_idx ;
               cmbPartidaMayorizada.Name = GXCCtl ;
               cmbPartidaMayorizada.WebTags = "" ;
               cmbPartidaMayorizada.addItem("0", "No", 0);
               cmbPartidaMayorizada.addItem("1", "Si", 0);
               if ( ( cmbPartidaMayorizada.ItemCount > 0 ) && (0==A211PartidaMayorizada) )
               {
                  A211PartidaMayorizada = (short)(NumberUtil.Val( cmbPartidaMayorizada.getItemValue(1), ".")) ;
               }
               GXCCtl = "PARTIDAESTADO_" + sGXsfl_24_idx ;
               cmbPartidaEstado.Name = GXCCtl ;
               cmbPartidaEstado.WebTags = "" ;
               cmbPartidaEstado.addItem("0", "Creada", 0);
               cmbPartidaEstado.addItem("1", "Emitida", 0);
               cmbPartidaEstado.addItem("2", "Cancelada", 0);
               if ( ( cmbPartidaEstado.ItemCount > 0 ) && (0==A289PartidaEstado) )
               {
                  A289PartidaEstado = (short)(NumberUtil.Val( cmbPartidaEstado.getItemValue(1), ".")) ;
               }
               Grid1_PageSize24 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV7PartidaFechaD = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PartidaFechaD", context.localUtil.Format(AV7PartidaFechaD, "99/99/99"));
               AV8PartidaFechaA = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PartidaFechaA", context.localUtil.Format(AV8PartidaFechaA, "99/99/99"));
               AV5ClinicaCodigo = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize24, AV7PartidaFechaD, AV8PartidaFechaA, AV5ClinicaCodigo) ;
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
         PA352( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START352( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_consultapartidas.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vPARTIDAFECHAD", context.localUtil.Format(AV7PartidaFechaD, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vPARTIDAFECHAA", context.localUtil.Format(AV8PartidaFechaA, "99/99/99"));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV5ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
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
            WE352( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT352( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_consultapartidas" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Partidas Contables" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_consultapartidas.aspx")  ;
      }

      protected void WB350( )
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
            wb_table1_2_352( true) ;
         }
         else
         {
            wb_table1_2_352( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_352e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START352( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Consulta de Partidas Contables", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP350( ) ;
      }

      protected void WS352( )
      {
         START352( ) ;
         EVT352( ) ;
      }

      protected void EVT352( )
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
                  if ( context.localUtil.CToD( cgiGet( "GXH_vPARTIDAFECHAD"), 2) != AV7PartidaFechaD )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vPARTIDAFECHAA"), 2) != AV8PartidaFechaA )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
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
                              /* Execute user event: E11352 */
                              E11352 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12352 */
                              E12352 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E13352 */
                              E13352 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E14352 */
                              E14352 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E15352 */
                              E15352 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NUEVA PARTIDA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E16352 */
                              E16352 ();
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
                              edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_24_idx ;
                              edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_24_idx ;
                              edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_24_idx ;
                              edtPartidaFecha_Internalname = "PARTIDAFECHA_"+sGXsfl_24_idx ;
                              cmbPartidaMayorizada_Internalname = "PARTIDAMAYORIZADA_"+sGXsfl_24_idx ;
                              cmbPartidaEstado_Internalname = "PARTIDAESTADO_"+sGXsfl_24_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A199TipoParCodigo = cgiGet( edtTipoParCodigo_Internalname) ;
                              A200TipoParNombre = cgiGet( edtTipoParNombre_Internalname) ;
                              A207PartidaId = (int)(context.localUtil.CToN( cgiGet( edtPartidaId_Internalname), ".", ",")) ;
                              A208PartidaFecha = context.localUtil.CToD( cgiGet( edtPartidaFecha_Internalname), 2) ;
                              cmbPartidaMayorizada.Name = cmbPartidaMayorizada_Internalname ;
                              cmbPartidaMayorizada.CurrentValue = cgiGet( cmbPartidaMayorizada_Internalname) ;
                              A211PartidaMayorizada = (short)(NumberUtil.Val( cgiGet( cmbPartidaMayorizada_Internalname), ".")) ;
                              cmbPartidaEstado.Name = cmbPartidaEstado_Internalname ;
                              cmbPartidaEstado.CurrentValue = cgiGet( cmbPartidaEstado_Internalname) ;
                              A289PartidaEstado = (short)(NumberUtil.Val( cgiGet( cmbPartidaEstado_Internalname), ".")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E17352 */
                                    E17352 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E18352 */
                                    E18352 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Partidafechad Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vPARTIDAFECHAD"), 2) != AV7PartidaFechaD )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Partidafechaa Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vPARTIDAFECHAA"), 2) != AV8PartidaFechaA )
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

      protected void WE352( )
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

      protected void PA352( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXCCtl = "PARTIDAMAYORIZADA_" + sGXsfl_24_idx ;
            cmbPartidaMayorizada.Name = GXCCtl ;
            cmbPartidaMayorizada.WebTags = "" ;
            cmbPartidaMayorizada.addItem("0", "No", 0);
            cmbPartidaMayorizada.addItem("1", "Si", 0);
            if ( ( cmbPartidaMayorizada.ItemCount > 0 ) && (0==A211PartidaMayorizada) )
            {
               A211PartidaMayorizada = (short)(NumberUtil.Val( cmbPartidaMayorizada.getItemValue(1), ".")) ;
            }
            GXCCtl = "PARTIDAESTADO_" + sGXsfl_24_idx ;
            cmbPartidaEstado.Name = GXCCtl ;
            cmbPartidaEstado.WebTags = "" ;
            cmbPartidaEstado.addItem("0", "Creada", 0);
            cmbPartidaEstado.addItem("1", "Emitida", 0);
            cmbPartidaEstado.addItem("2", "Cancelada", 0);
            if ( ( cmbPartidaEstado.ItemCount > 0 ) && (0==A289PartidaEstado) )
            {
               A289PartidaEstado = (short)(NumberUtil.Val( cmbPartidaEstado.getItemValue(1), ".")) ;
            }
            GX_FocusControl = edtavPartidafechad_Internalname ;
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
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_24_idx ;
         edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_24_idx ;
         edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_24_idx ;
         edtPartidaFecha_Internalname = "PARTIDAFECHA_"+sGXsfl_24_idx ;
         cmbPartidaMayorizada_Internalname = "PARTIDAMAYORIZADA_"+sGXsfl_24_idx ;
         cmbPartidaEstado_Internalname = "PARTIDAESTADO_"+sGXsfl_24_idx ;
         while ( nGXsfl_24_idx <= nRC_Grid1 )
         {
            sendrow_242( ) ;
            nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_24_idx ;
            edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_24_idx ;
            edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_24_idx ;
            edtPartidaFecha_Internalname = "PARTIDAFECHA_"+sGXsfl_24_idx ;
            cmbPartidaMayorizada_Internalname = "PARTIDAMAYORIZADA_"+sGXsfl_24_idx ;
            cmbPartidaEstado_Internalname = "PARTIDAESTADO_"+sGXsfl_24_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize24 ,
                                        DateTime AV7PartidaFechaD ,
                                        DateTime AV8PartidaFechaA ,
                                        String AV5ClinicaCodigo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize24) ;
         RF352( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF352( ) ;
         /* End function Refresh */
      }

      protected void RF352( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 24 ;
         nGXsfl_24_idx = 1 ;
         sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_24_idx ;
         edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_24_idx ;
         edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_24_idx ;
         edtPartidaFecha_Internalname = "PARTIDAFECHA_"+sGXsfl_24_idx ;
         cmbPartidaMayorizada_Internalname = "PARTIDAMAYORIZADA_"+sGXsfl_24_idx ;
         cmbPartidaEstado_Internalname = "PARTIDAESTADO_"+sGXsfl_24_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_24_idx ;
            edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_24_idx ;
            edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_24_idx ;
            edtPartidaFecha_Internalname = "PARTIDAFECHA_"+sGXsfl_24_idx ;
            cmbPartidaMayorizada_Internalname = "PARTIDAMAYORIZADA_"+sGXsfl_24_idx ;
            cmbPartidaEstado_Internalname = "PARTIDAESTADO_"+sGXsfl_24_idx ;
            /* Using cursor H00352 */
            pr_default.execute(0, new Object[] {AV5ClinicaCodigo, AV7PartidaFechaD, AV8PartidaFechaA});
            nGXsfl_24_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 12 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A289PartidaEstado = H00352_A289PartidaEstado[0] ;
               A211PartidaMayorizada = H00352_A211PartidaMayorizada[0] ;
               A208PartidaFecha = H00352_A208PartidaFecha[0] ;
               A207PartidaId = H00352_A207PartidaId[0] ;
               A200TipoParNombre = H00352_A200TipoParNombre[0] ;
               A199TipoParCodigo = H00352_A199TipoParCodigo[0] ;
               A41ClinicaCodigo = H00352_A41ClinicaCodigo[0] ;
               A200TipoParNombre = H00352_A200TipoParNombre[0] ;
               /* Execute user event: E18352 */
               E18352 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 24 ;
            WB350( ) ;
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
         /* Using cursor H00353 */
         pr_default.execute(1, new Object[] {AV5ClinicaCodigo, AV7PartidaFechaD, AV8PartidaFechaA});
         GRID1_nRecordCount = H00353_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
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

      protected void STRUP350( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E17352 */
         E17352 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( context.localUtil.VCDate( cgiGet( edtavPartidafechad_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Partida Fecha D"}), 1, "vPARTIDAFECHAD");
               GX_FocusControl = edtavPartidafechad_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7PartidaFechaD = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PartidaFechaD", context.localUtil.Format(AV7PartidaFechaD, "99/99/99"));
            }
            else
            {
               AV7PartidaFechaD = context.localUtil.CToD( cgiGet( edtavPartidafechad_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PartidaFechaD", context.localUtil.Format(AV7PartidaFechaD, "99/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavPartidafechaa_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Partida Fecha A"}), 1, "vPARTIDAFECHAA");
               GX_FocusControl = edtavPartidafechaa_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8PartidaFechaA = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PartidaFechaA", context.localUtil.Format(AV8PartidaFechaA, "99/99/99"));
            }
            else
            {
               AV8PartidaFechaA = context.localUtil.CToD( cgiGet( edtavPartidafechaa_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PartidaFechaA", context.localUtil.Format(AV8PartidaFechaA, "99/99/99"));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ",")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ",")) ;
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
         /* Execute user event: E17352 */
         E17352 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17352( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV6Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV6Parametros = GXt_SdtParametros4 ;
         AV5ClinicaCodigo = AV6Parametros.gxTpr_Pclinicacodigo ;
         AV7PartidaFechaD = context.localUtil.YMDToD( DateTimeUtil.Year( Gx_date), DateTimeUtil.Month( Gx_date), 1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PartidaFechaD", context.localUtil.Format(AV7PartidaFechaD, "99/99/99"));
         AV8PartidaFechaA = DateTimeUtil.DateEndOfMonth( AV7PartidaFechaD) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PartidaFechaA", context.localUtil.Format(AV8PartidaFechaA, "99/99/99"));
      }

      protected void E11352( )
      {
         /* 'First' Routine */
         subgrid1_firstpage( ) ;
      }

      protected void E12352( )
      {
         /* 'Previous' Routine */
         subgrid1_previouspage( ) ;
      }

      protected void E13352( )
      {
         /* 'Next' Routine */
         subgrid1_nextpage( ) ;
      }

      protected void E14352( )
      {
         /* 'Last' Routine */
         subgrid1_lastpage( ) ;
      }

      protected void E15352( )
      {
         /* 'Regresar' Routine */
         context.wjLoc = formatLink("principal.aspx")  ;
      }

      protected void E16352( )
      {
         /* 'Nueva Partida' Routine */
         context.wjLoc = formatLink("wp_registrapartida.aspx")  ;
      }

      private void E18352( )
      {
         /* Load Routine */
         if ( ( subGrid1_Islastpage == 1 ) || ( 12 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_242( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_2_352( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Partidas Contables", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_consultapartidas.htm");
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
            wb_table2_11_352( true) ;
         }
         else
         {
            wb_table2_11_352( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_352e( bool wbgen )
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Tipo_Partida") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Partida") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Mayorizada") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Partida Estado") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A200TipoParNombre));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PartidaId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A208PartidaFecha, "99/99/99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A211PartidaMayorizada), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A289PartidaEstado), 1, 0, ".", "")));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "|<", bttButton1_Jsonclick, 5, "|<", "", StyleString, ClassString, 1, 1, "standard", "E\\'FIRST\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_consultapartidas.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "<", bttButton2_Jsonclick, 5, "<", "", StyleString, ClassString, 1, 1, "standard", "E\\'PREVIOUS\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_consultapartidas.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", ">", bttButton3_Jsonclick, 5, ">", "", StyleString, ClassString, 1, 1, "standard", "E\\'NEXT\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_consultapartidas.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton4_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", ">|", bttButton4_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'LAST\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_consultapartidas.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton5_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "Nueva Partida", bttButton5_Jsonclick, 5, "Nueva Partida", "", StyleString, ClassString, 1, 1, "standard", "E\\'NUEVA PARTIDA\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_consultapartidas.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton6_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "Regresar", bttButton6_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_consultapartidas.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_352e( true) ;
         }
         else
         {
            wb_table1_2_352e( false) ;
         }
      }

      protected void wb_table2_11_352( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Fecha Del", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_consultapartidas.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Fecha Al", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_consultapartidas.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PartidaFechaD", context.localUtil.Format(AV7PartidaFechaD, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavPartidafechad_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPartidafechad_Internalname, context.localUtil.Format(AV7PartidaFechaD, "99/99/99"), context.localUtil.Format( AV7PartidaFechaD, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(19);\"", "", "", "", "", edtavPartidafechad_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_consultapartidas.htm");
            GxWebStd.gx_bitmap( context, edtavPartidafechad_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_consultapartidas.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PartidaFechaA", context.localUtil.Format(AV8PartidaFechaA, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavPartidafechaa_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavPartidafechaa_Internalname, context.localUtil.Format(AV8PartidaFechaA, "99/99/99"), context.localUtil.Format( AV8PartidaFechaA, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(21);\"", "", "", "", "", edtavPartidafechaa_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_consultapartidas.htm");
            GxWebStd.gx_bitmap( context, edtavPartidafechaa_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_consultapartidas.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_352e( true) ;
         }
         else
         {
            wb_table2_11_352e( false) ;
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
         PA352( ) ;
         WS352( ) ;
         WE352( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?158763");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("wp_consultapartidas.js", "?158764");
         /* End function include_jscripts */
      }

      protected void sendrow_242( )
      {
         WB350( ) ;
         if ( ( 12 * 1 == 0 ) || ( nGXsfl_24_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoParCodigo_Internalname,StringUtil.RTrim( A199TipoParCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoParCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoParNombre_Internalname,StringUtil.RTrim( A200TipoParNombre),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoParNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A207PartidaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A207PartidaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPartidaFecha_Internalname,context.localUtil.Format(A208PartidaFecha, "99/99/99"),context.localUtil.Format( A208PartidaFecha, "99/99/99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPartidaFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)24,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_24_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PARTIDAMAYORIZADA_" + sGXsfl_24_idx ;
               cmbPartidaMayorizada.Name = GXCCtl ;
               cmbPartidaMayorizada.WebTags = "" ;
               cmbPartidaMayorizada.addItem("0", "No", 0);
               cmbPartidaMayorizada.addItem("1", "Si", 0);
               if ( ( cmbPartidaMayorizada.ItemCount > 0 ) && (0==A211PartidaMayorizada) )
               {
                  A211PartidaMayorizada = (short)(NumberUtil.Val( cmbPartidaMayorizada.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPartidaMayorizada,(String)cmbPartidaMayorizada_Internalname,StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0),(short)1,(String)cmbPartidaMayorizada_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbPartidaMayorizada.CurrentValue = StringUtil.Str( (decimal)(A211PartidaMayorizada), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPartidaMayorizada_Internalname, "Values", (String)(cmbPartidaMayorizada.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_24_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PARTIDAESTADO_" + sGXsfl_24_idx ;
               cmbPartidaEstado.Name = GXCCtl ;
               cmbPartidaEstado.WebTags = "" ;
               cmbPartidaEstado.addItem("0", "Creada", 0);
               cmbPartidaEstado.addItem("1", "Emitida", 0);
               cmbPartidaEstado.addItem("2", "Cancelada", 0);
               if ( ( cmbPartidaEstado.ItemCount > 0 ) && (0==A289PartidaEstado) )
               {
                  A289PartidaEstado = (short)(NumberUtil.Val( cmbPartidaEstado.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPartidaEstado,(String)cmbPartidaEstado_Internalname,StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0),(short)1,(String)cmbPartidaEstado_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbPartidaEstado.CurrentValue = StringUtil.Str( (decimal)(A289PartidaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPartidaEstado_Internalname, "Values", (String)(cmbPartidaEstado.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_24_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_24_idx ;
            edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_24_idx ;
            edtPartidaId_Internalname = "PARTIDAID_"+sGXsfl_24_idx ;
            edtPartidaFecha_Internalname = "PARTIDAFECHA_"+sGXsfl_24_idx ;
            cmbPartidaMayorizada_Internalname = "PARTIDAMAYORIZADA_"+sGXsfl_24_idx ;
            cmbPartidaEstado_Internalname = "PARTIDAESTADO_"+sGXsfl_24_idx ;
         }
         /* End function sendrow_242 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavPartidafechad_Internalname = "vPARTIDAFECHAD" ;
         edtavPartidafechaa_Internalname = "vPARTIDAFECHAA" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttButton4_Internalname = "BUTTON4" ;
         bttButton5_Internalname = "BUTTON5" ;
         bttButton6_Internalname = "BUTTON6" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         cmbPartidaEstado_Jsonclick = "" ;
         cmbPartidaMayorizada_Jsonclick = "" ;
         edtPartidaFecha_Jsonclick = "" ;
         edtPartidaId_Jsonclick = "" ;
         edtTipoParNombre_Jsonclick = "" ;
         edtTipoParCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavPartidafechaa_Jsonclick = "" ;
         edtavPartidafechad_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Consulta de Partidas Contables" ;
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
         Gx_date = DateTime.MinValue ;
         GXCCtl = "" ;
         AV7PartidaFechaD = DateTime.MinValue ;
         AV8PartidaFechaA = DateTime.MinValue ;
         AV5ClinicaCodigo = "" ;
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
         edtTipoParNombre_Internalname = "" ;
         edtPartidaId_Internalname = "" ;
         edtPartidaFecha_Internalname = "" ;
         cmbPartidaMayorizada_Internalname = "" ;
         cmbPartidaEstado_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A199TipoParCodigo = "" ;
         A200TipoParNombre = "" ;
         A208PartidaFecha = DateTime.MinValue ;
         GXKey = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H00352_A289PartidaEstado = new short[1] ;
         H00352_A211PartidaMayorizada = new short[1] ;
         H00352_A208PartidaFecha = new DateTime[] {DateTime.MinValue} ;
         H00352_A207PartidaId = new int[1] ;
         H00352_A200TipoParNombre = new String[] {""} ;
         H00352_A199TipoParCodigo = new String[] {""} ;
         H00352_A41ClinicaCodigo = new String[] {""} ;
         H00353_AGRID1_nRecordCount = new int[1] ;
         AV6Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
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
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         bttButton5_Jsonclick = "" ;
         bttButton6_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         GXt_char7 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_consultapartidas__default(),
            new Object[][] {
                new Object[] {
               H00352_A289PartidaEstado, H00352_A211PartidaMayorizada, H00352_A208PartidaFecha, H00352_A207PartidaId, H00352_A200TipoParNombre, H00352_A199TipoParCodigo, H00352_A41ClinicaCodigo
               }
               , new Object[] {
               H00353_AGRID1_nRecordCount
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
      private short A211PartidaMayorizada ;
      private short A289PartidaEstado ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize24 ;
      private int GRID1_nFirstRecordOnPage ;
      private int A207PartidaId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_24_idx="0001" ;
      private String GXCCtl ;
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
      private String edtTipoParNombre_Internalname ;
      private String edtPartidaId_Internalname ;
      private String edtPartidaFecha_Internalname ;
      private String cmbPartidaMayorizada_Internalname ;
      private String cmbPartidaEstado_Internalname ;
      private String GXKey ;
      private String edtavPartidafechad_Internalname ;
      private String scmdbuf ;
      private String edtavPartidafechaa_Internalname ;
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
      private String bttButton6_Internalname ;
      private String bttButton6_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavPartidafechad_Jsonclick ;
      private String edtavPartidafechaa_Jsonclick ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtTipoParCodigo_Jsonclick ;
      private String edtTipoParNombre_Jsonclick ;
      private String edtPartidaId_Jsonclick ;
      private String edtPartidaFecha_Jsonclick ;
      private String cmbPartidaMayorizada_Jsonclick ;
      private String cmbPartidaEstado_Jsonclick ;
      private String GXt_char9 ;
      private DateTime Gx_date ;
      private DateTime AV7PartidaFechaD ;
      private DateTime AV8PartidaFechaA ;
      private DateTime A208PartidaFecha ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5ClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String A200TipoParNombre ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPartidaMayorizada ;
      private GXCombobox cmbPartidaEstado ;
      private IDataStoreProvider pr_default ;
      private short[] H00352_A289PartidaEstado ;
      private short[] H00352_A211PartidaMayorizada ;
      private DateTime[] H00352_A208PartidaFecha ;
      private int[] H00352_A207PartidaId ;
      private String[] H00352_A200TipoParNombre ;
      private String[] H00352_A199TipoParCodigo ;
      private String[] H00352_A41ClinicaCodigo ;
      private int[] H00353_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV6Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class wp_consultapartidas__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00352 ;
          prmH00352 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7PartidaFechaD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8PartidaFechaA",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmH00353 ;
          prmH00353 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7PartidaFechaD",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV8PartidaFechaA",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00352", "SELECT T1.[PartidaEstado], T1.[PartidaMayorizada], T1.[PartidaFecha], T1.[PartidaId], T2.[TipoParNombre], T1.[TipoParCodigo], T1.[ClinicaCodigo] FROM ([PartidaEnc] T1 WITH (NOLOCK) INNER JOIN [TipoPartida] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[TipoParCodigo] = T1.[TipoParCodigo]) WHERE (T1.[ClinicaCodigo] = @AV5ClinicaCodigo) AND (T1.[PartidaFecha] >= @AV7PartidaFechaD) AND (T1.[PartidaFecha] <= @AV8PartidaFechaA) ORDER BY T1.[ClinicaCodigo], T1.[TipoParCodigo], T1.[PartidaId]  OPTION (FAST 13)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00352,13,0,true,false )
             ,new CursorDef("H00353", "SELECT COUNT(*) FROM ([PartidaEnc] T1 WITH (NOLOCK) INNER JOIN [TipoPartida] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[TipoParCodigo] = T1.[TipoParCodigo]) WHERE (T1.[ClinicaCodigo] = @AV5ClinicaCodigo) AND (T1.[PartidaFecha] >= @AV7PartidaFechaD) AND (T1.[PartidaFecha] <= @AV8PartidaFechaA) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00353,1,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                break;
             case 1 :
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
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                break;
       }
    }

 }

}
