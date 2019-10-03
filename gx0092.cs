/*
               File: Gx0092
        Description: Selection List Especialidades de médico
             Author: GeneXus C# Generator version 10_1_1-28290
       Generated on: 3/1/2019 9:50:44.0
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
   public class gx0092 : GXDataArea
   {
      public gx0092( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx0092( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_pClinicaCodigo ,
                           String aP1_pMedicoCodigo ,
                           ref int aP2_pMedicoId )
      {
         this.AV7pClinicaCodigo = aP0_pClinicaCodigo;
         this.AV8pMedicoCodigo = aP1_pMedicoCodigo;
         this.AV9pMedicoId = aP2_pMedicoId;
         executePrivate();
         aP2_pMedicoId=this.AV9pMedicoId;
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
               nGXsfl_21_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_21_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_21_idx, sGXsfl_21_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize21 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cMedicoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cMedicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cMedicoId), 9, 0)));
               AV7pClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7pClinicaCodigo", AV7pClinicaCodigo);
               AV8pMedicoCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8pMedicoCodigo", AV8pMedicoCodigo);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize21, AV6cMedicoId, AV7pClinicaCodigo, AV8pMedicoCodigo) ;
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
            if ( ! entryPointCalled )
            {
               AV7pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7pClinicaCodigo", AV7pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8pMedicoCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8pMedicoCodigo", AV8pMedicoCodigo);
                  AV9pMedicoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pMedicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9pMedicoId), 9, 0)));
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
         context.DoAfterInit();
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA0F2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0F2( ) ;
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
            context.AddJavascriptSource("gxgral.js", "?28290");
            context.AddJavascriptSource("gxcfg.js", "?28290");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?28290");
            context.AddJavascriptSource("gxfxSD.js", "?28290");
            context.AddJavascriptSource("gxtypesSD.js", "?28290");
            context.AddJavascriptSource("gxpopupSD.js", "?28290");
            context.AddJavascriptSource("gxfrmutlSD.js", "?28290");
            context.AddJavascriptSource("gxgridSD.js", "?28290");
            context.AddJavascriptSource("JavaScripTableSD.js", "?28290");
            context.AddJavascriptSource("rijndaelSD.js", "?28290");
            context.AddJavascriptSource("gxgralSD.js", "?28290");
            context.AddJavascriptSource("gxcfg.js", "?28290");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"bottommargin=\"0\""+" "+"topmargin=\"0\""+" "+"marginheight=\"0\""+" "+"leftmargin=\"0\""+" "+"marginwidth=\"0\""+" "+"class=\"Form\""+" "+"rightmargin=\"0\""+" "+" style=\"-moz-opacity: 0;opacity: 0;\" "+" bgcolor=\""+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"POST\" action=\""+formatLink("gx0092.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV7pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV8pMedicoCodigo)) + "," + UrlEncode("" +AV9pMedicoId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH__CMEDICOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cMedicoId), 9, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "sCallerURL", StringUtil.RTrim( context.sCallerURL));
         GxWebStd.gx_hidden_field( context, "_PCLINICACODIGO", StringUtil.RTrim( AV7pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "_PMEDICOCODIGO", StringUtil.RTrim( AV8pMedicoCodigo));
         GxWebStd.gx_hidden_field( context, "_PMEDICOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9pMedicoId), 9, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
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
            WE0F2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0F2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx0092" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Especialidades de médico" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0092.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV7pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV8pMedicoCodigo)) + "," + UrlEncode("" +AV9pMedicoId) ;
      }

      protected void WB0F0( )
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
            wb_table1_2_0F2( true) ;
         }
         else
         {
            wb_table1_2_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0F2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_1-28290", 0) ;
         Form.Meta.addItem("Description", "Selection List Especialidades de médico", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            context.sCallerURL = cgiGet( "sCallerURL") ;
         }
         else
         {
            context.sCallerURL = context.GetReferer( ) ;
         }
         wbErr = false ;
         STRUP0F0( ) ;
      }

      protected void WS0F2( )
      {
         START0F2( ) ;
         EVT0F2( ) ;
      }

      protected void EVT0F2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH__CMEDICOID"), ",", ".") != Convert.ToDecimal( AV6cMedicoId )) )
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
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_21_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_21_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_21_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_21_idx ;
                              edtMedicoId_Internalname = "MEDICOID_"+sGXsfl_21_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_21_idx ;
                              edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_21_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A26MedicoId = (int)(context.localUtil.CToN( cgiGet( edtMedicoId_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26MedicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A26MedicoId), 9, 0)));
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
                              A19MedicoCodigo = cgiGet( edtMedicoCodigo_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110F2 */
                                    E110F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120F2 */
                                    E120F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cmedicoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH__CMEDICOID"), ",", ".") != Convert.ToDecimal( AV6cMedicoId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E130F2 */
                                          E130F2 ();
                                       }
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
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    sEvt = cgiGet( "GRID1PAGING") ;
                                    if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                                    {
                                       subgrid1_firstpage( ) ;
                                    }
                                    else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                                    {
                                       subgrid1_previouspage( ) ;
                                    }
                                    else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                                    {
                                       subgrid1_nextpage( ) ;
                                    }
                                    else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                                    {
                                       subgrid1_lastpage( ) ;
                                    }
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

      protected void WE0F2( )
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

      protected void PA0F2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCmedicoid_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_21_idx ,
                                       String sGXsfl_21_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_21_idx ;
         edtMedicoId_Internalname = "MEDICOID_"+sGXsfl_21_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_21_idx ;
         edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_21_idx ;
         while ( nGXsfl_21_idx <= nRC_Grid1 )
         {
            sendrow_212( ) ;
            nGXsfl_21_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_21_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_21_idx+1)) ;
            sGXsfl_21_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_21_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_21_idx ;
            edtMedicoId_Internalname = "MEDICOID_"+sGXsfl_21_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_21_idx ;
            edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_21_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize21 ,
                                        int AV6cMedicoId ,
                                        String AV7pClinicaCodigo ,
                                        String AV8pMedicoCodigo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize21) ;
         RF0F2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0F2( ) ;
         /* End function Refresh */
      }

      protected void RF0F2( )
      {
         Grid1Container.Clear();
         Grid1Container.SetWrapped(nGXWrapped);
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 21 ;
         nGXsfl_21_idx = 1 ;
         sGXsfl_21_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_21_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_21_idx ;
         edtMedicoId_Internalname = "MEDICOID_"+sGXsfl_21_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_21_idx ;
         edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_21_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H000F2 */
            pr_default.execute(0, new Object[] {AV7pClinicaCodigo, AV8pMedicoCodigo, AV6cMedicoId});
            nGXsfl_21_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A19MedicoCodigo = H000F2_A19MedicoCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19MedicoCodigo", A19MedicoCodigo);
               A41ClinicaCodigo = H000F2_A41ClinicaCodigo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41ClinicaCodigo", A41ClinicaCodigo);
               A26MedicoId = H000F2_A26MedicoId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26MedicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(A26MedicoId), 9, 0)));
               /* Execute user event: E120F2 */
               E120F2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 21 ;
            WB0F0( ) ;
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
         /* Using cursor H000F3 */
         pr_default.execute(1, new Object[] {AV7pClinicaCodigo, AV8pMedicoCodigo, AV6cMedicoId});
         GRID1_nRecordCount = H000F3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
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

      protected void STRUP0F0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110F2 */
         E110F2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmedicoid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmedicoid_Internalname), ",", ".") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "_CMEDICOID");
               GX_FocusControl = edtavCmedicoid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cMedicoId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cMedicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cMedicoId), 9, 0)));
            }
            else
            {
               AV6cMedicoId = (int)(context.localUtil.CToN( cgiGet( edtavCmedicoid_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cMedicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cMedicoId), 9, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            context.sCallerURL = cgiGet( "sCallerURL") ;
            AV7pClinicaCodigo = cgiGet( "_PCLINICACODIGO") ;
            AV8pMedicoCodigo = cgiGet( "_PMEDICOCODIGO") ;
            AV9pMedicoId = (int)(context.localUtil.CToN( cgiGet( "_PMEDICOID"), ",", ".")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
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
         /* Execute user event: E110F2 */
         E110F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110F2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Especialidades de médico", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E120F2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_212( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E130F2 */
         E130F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130F2( )
      {
         /* Enter Routine */
         AV9pMedicoId = A26MedicoId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pMedicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9pMedicoId), 9, 0)));
         context.setWebReturnParms(new Object[] {(int)AV9pMedicoId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+" "+"align=\""+"center"+"\""+" "+">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset name=\""+grpGroup1_Internalname+"\""+" id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_0F2( true) ;
         }
         else
         {
            wb_table2_9_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset name=\""+grpGroup2_Internalname+"\""+" id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_18_0F2( true) ;
         }
         else
         {
            wb_table3_18_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table3_18_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0F2e( true) ;
         }
         else
         {
            wb_table1_2_0F2e( false) ;
         }
      }

      protected void wb_table3_18_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+" "+"colspan=\""+"3"+"\""+" "+">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( nGXWrapped == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "all", 0);
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
               context.WriteHtmlText( "<th align=\""+""+"\" style=\""+((-1==0) ? "display:none;" : "")+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" style=\""+((-1==0) ? "display:none;" : "")+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" style=\""+"display:none;"+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" style=\""+"display:none;"+"\" "+" nowrap"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((subGrid1_Titlebackstyle==0) ? "background:transparent;" : "")+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
         }
         if ( wbEnd == 21 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_21_idx-1) ;
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26MedicoId), 9, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtMedicoId_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A19MedicoCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div"+"\" cmpCtx="+"''"+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+" "+"align=\""+"right"+"\""+" "+">") ;
            wb_table4_28_0F2( true) ;
         }
         else
         {
            wb_table4_28_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table4_28_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_18_0F2e( true) ;
         }
         else
         {
            wb_table3_18_0F2e( false) ;
         }
      }

      protected void wb_table4_28_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "31" + "," + "''" + "," + "false" + ",'" + "" + "'," + "21" + ")\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, 2, bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "standard", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(21), 3, 0)+","+"null"+");", "", "HLP_Gx0092.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_28_0F2e( true) ;
         }
         else
         {
            wb_table4_28_0F2e( false) ;
         }
      }

      protected void wb_table2_9_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr"+">") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmedicoid_Internalname, 1, 1, 0, "Id", "", "", "", 0, lblTextblockmedicoid_Jsonclick, "", StyleString, ClassString, "HLP_Gx0092.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td"+">") ;
            /* Single line edit */
            TempTags = " " + " onfocus=\"gx.evt.onfocus(this, " + "14" + "," + "''" + "," + "false" + ",'" + sGXsfl_21_idx + "'," + "21" + ")\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCmedicoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cMedicoId), 9, 0, ",", "")), "", 9, "chr", 1, "row", 9, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cMedicoId), "ZZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavCmedicoid_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx0092.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_0F2e( true) ;
         }
         else
         {
            wb_table2_9_0F2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7pClinicaCodigo", AV7pClinicaCodigo);
         AV8pMedicoCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8pMedicoCodigo", AV8pMedicoCodigo);
         AV9pMedicoId = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9pMedicoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9pMedicoId), 9, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         PA0F2( ) ;
         WS0F2( ) ;
         WE0F2( ) ;
         this.cleanup();
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?1634658");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?950458");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?28290");
         context.AddJavascriptSource("gx0092.js", "?950458");
         /* End function include_jscripts */
      }

      protected void sendrow_212( )
      {
         WB0F0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_21_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,nGXWrapped) ;
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
               subGrid1_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_21_idx) % (2)) == 0 )
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
                  subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+((subGrid1_Backcolorstyle==0) ? "background:transparent;" : "")+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A26MedicoId), 9, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Fantastic",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            ROClassString = ClassString ;
            edtMedicoId_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A26MedicoId), 9, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtMedicoId_Internalname, "Link", edtMedicoId_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMedicoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A26MedicoId), 9, 0, ",", "")),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)9,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtMedicoId_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A26MedicoId), "ZZZZZZZZ9"),(String)"",(short)0,(String)edtMedicoId_Jsonclick,(String)"",(short)21,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A41ClinicaCodigo, "")),(String)"",(short)0,(String)edtClinicaCodigo_Jsonclick,(String)"",(short)21,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( nGXWrapped == 1 )
            {
               context.WriteHtmlText( "<td valign=top align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = ((subGrid1_Backstyle==0) ? "background:transparent;" : "") ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMedicoCodigo_Internalname,StringUtil.RTrim( A19MedicoCodigo),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A19MedicoCodigo, "")),(String)"",(short)0,(String)edtMedicoCodigo_Jsonclick,(String)"",(short)21,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_21_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_21_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_21_idx+1)) ;
            sGXsfl_21_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_21_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "_LINKSELECTION_"+sGXsfl_21_idx ;
            edtMedicoId_Internalname = "MEDICOID_"+sGXsfl_21_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_21_idx ;
            edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_21_idx ;
         }
         /* End function sendrow_212 */
      }

      public override void initialize_properties( )
      {
         lblTextblockmedicoid_Internalname = "TEXTBLOCKMEDICOID" ;
         edtavCmedicoid_Internalname = "_CMEDICOID" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
         edtMedicoCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtMedicoId_Jsonclick = "" ;
         subGrid1_Backstyle = 1 ;
         edtavCmedicoid_Jsonclick = "" ;
         edtMedicoId_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Titlebackstyle = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Especialidades de médico" ;
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
         wcpOAV7pClinicaCodigo = "" ;
         wcpOAV8pMedicoCodigo = "" ;
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
         edtavLinkselection_Internalname = "" ;
         edtMedicoId_Internalname = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtMedicoCodigo_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A19MedicoCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H000F2_A19MedicoCodigo = new String[] {""} ;
         H000F2_A41ClinicaCodigo = new String[] {""} ;
         H000F2_A26MedicoId = new int[1] ;
         H000F3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char1 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         GXt_char4 = "" ;
         lblTextblockmedicoid_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char5 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0092__default(),
            new Object[][] {
                new Object[] {
               H000F2_A19MedicoCodigo, H000F2_A41ClinicaCodigo, H000F2_A26MedicoId
               }
               , new Object[] {
               H000F3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_21_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV9pMedicoId ;
      private int wcpOAV9pMedicoId ;
      private int Grid1_PageSize21 ;
      private int AV6cMedicoId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A26MedicoId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_21_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtMedicoId_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtMedicoCodigo_Internalname ;
      private String edtavCmedicoid_Internalname ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char1 ;
      private String edtavLinkselection_Link ;
      private String edtMedicoId_Link ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String GXt_char4 ;
      private String lblTextblockmedicoid_Internalname ;
      private String lblTextblockmedicoid_Jsonclick ;
      private String edtavCmedicoid_Jsonclick ;
      private String ROClassString ;
      private String edtMedicoId_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtMedicoCodigo_Jsonclick ;
      private String GXt_char5 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV7pClinicaCodigo ;
      private String AV8pMedicoCodigo ;
      private String wcpOAV7pClinicaCodigo ;
      private String wcpOAV8pMedicoCodigo ;
      private String A41ClinicaCodigo ;
      private String A19MedicoCodigo ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private int aP2_pMedicoId ;
      private IDataStoreProvider pr_default ;
      private String[] H000F2_A19MedicoCodigo ;
      private String[] H000F2_A41ClinicaCodigo ;
      private int[] H000F2_A26MedicoId ;
      private int[] H000F3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class gx0092__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000F2 ;
          prmH000F2 = new Object[] {
          new Object[] {"@AV7pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8pMedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV6cMedicoId",SqlDbType.Int,9,0}
          } ;
          Object[] prmH000F3 ;
          prmH000F3 = new Object[] {
          new Object[] {"@AV7pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8pMedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV6cMedicoId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000F2", "SELECT [MedicoCodigo], [ClinicaCodigo], [MedicoId] FROM [MedicoEsp] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV7pClinicaCodigo and [MedicoCodigo] = @AV8pMedicoCodigo and [MedicoId] >= @AV6cMedicoId ORDER BY [ClinicaCodigo], [MedicoCodigo], [MedicoId]  OPTION (FAST 1)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F2,11,0,false,false )
             ,new CursorDef("H000F3", "SELECT COUNT(*) FROM [MedicoEsp] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV7pClinicaCodigo and [MedicoCodigo] = @AV8pMedicoCodigo and [MedicoId] >= @AV6cMedicoId ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F3,1,0,false,false )
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
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
