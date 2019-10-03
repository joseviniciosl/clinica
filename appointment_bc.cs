/*
               File: Appointment_BC
        Description: Agenda de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/10/2019 15:21:41.85
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
   public class appointment_bc : GXHttpHandler, IGxSilentTrn
   {
      public appointment_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public appointment_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      protected void INITTRN( )
      {
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: E111B2 */
            E111B2 ();
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z240AppointmentCode = A240AppointmentCode ;
               SetMode( "UPD") ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_1B0( )
      {
         BeforeValidate1B59( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1B59( ) ;
            }
            else
            {
               CheckExtendedTable1B59( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors1B59( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1 ;
         }
      }

      protected void E121B2( )
      {
         /* Start Routine */
      }

      protected void E111B2( )
      {
         /* After Trn Routine */
      }

      protected void ZM1B59( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z67PacienteId = A67PacienteId ;
            Z244AppointmentStartDate = A244AppointmentStartDate ;
            Z242AppointmentEndDate = A242AppointmentEndDate ;
            Z243AppointmentObs = A243AppointmentObs ;
         }
         if ( GX_JID == -3 )
         {
            Z240AppointmentCode = A240AppointmentCode ;
            Z67PacienteId = A67PacienteId ;
            Z244AppointmentStartDate = A244AppointmentStartDate ;
            Z242AppointmentEndDate = A242AppointmentEndDate ;
            Z243AppointmentObs = A243AppointmentObs ;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load1B59( )
      {
         /* Using cursor BC001B4 */
         pr_default.execute(2, new Object[] {A240AppointmentCode});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound59 = 1 ;
            A67PacienteId = BC001B4_A67PacienteId[0] ;
            A244AppointmentStartDate = BC001B4_A244AppointmentStartDate[0] ;
            A242AppointmentEndDate = BC001B4_A242AppointmentEndDate[0] ;
            A243AppointmentObs = BC001B4_A243AppointmentObs[0] ;
            ZM1B59( -3) ;
         }
         pr_default.close(2);
         OnLoadActions1B59( ) ;
      }

      protected void OnLoadActions1B59( )
      {
      }

      protected void CheckExtendedTable1B59( )
      {
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A244AppointmentStartDate) || ( A244AppointmentStartDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Inicia fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
         if ( ! ( (DateTime.MinValue==A242AppointmentEndDate) || ( A242AppointmentEndDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("Campo Finaliza fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors1B59( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey1B59( )
      {
         /* Using cursor BC001B5 */
         pr_default.execute(3, new Object[] {A240AppointmentCode});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound59 = 1 ;
         }
         else
         {
            RcdFound59 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC001B3 */
         pr_default.execute(1, new Object[] {A240AppointmentCode});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1B59( 3) ;
            RcdFound59 = 1 ;
            A240AppointmentCode = BC001B3_A240AppointmentCode[0] ;
            A67PacienteId = BC001B3_A67PacienteId[0] ;
            A244AppointmentStartDate = BC001B3_A244AppointmentStartDate[0] ;
            A242AppointmentEndDate = BC001B3_A242AppointmentEndDate[0] ;
            A243AppointmentObs = BC001B3_A243AppointmentObs[0] ;
            Z240AppointmentCode = A240AppointmentCode ;
            sMode59 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Load1B59( ) ;
            Gx_mode = sMode59 ;
         }
         else
         {
            RcdFound59 = 0 ;
            InitializeNonKey1B59( ) ;
            sMode59 = Gx_mode ;
            Gx_mode = "DSP" ;
            standaloneModal( ) ;
            Gx_mode = sMode59 ;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1B59( ) ;
         if ( RcdFound59 == 0 )
         {
            Gx_mode = "INS" ;
         }
         else
         {
            Gx_mode = "UPD" ;
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_1B0( ) ;
         IsConfirmed = 0 ;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency1B59( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC001B2 */
            pr_default.execute(0, new Object[] {A240AppointmentCode});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Appointment"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z67PacienteId != BC001B2_A67PacienteId[0] ) || ( Z244AppointmentStartDate != BC001B2_A244AppointmentStartDate[0] ) || ( Z242AppointmentEndDate != BC001B2_A242AppointmentEndDate[0] ) || ( StringUtil.StrCmp(Z243AppointmentObs, BC001B2_A243AppointmentObs[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Appointment"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert1B59( )
      {
         BeforeValidate1B59( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1B59( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1B59( 0) ;
            CheckOptimisticConcurrency1B59( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1B59( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1B59( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001B6 */
                     pr_default.execute(4, new Object[] {A240AppointmentCode, A67PacienteId, A244AppointmentStartDate, A242AppointmentEndDate, A243AppointmentObs});
                     pr_default.close(4);
                     if ( (pr_default.getStatus(4) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), 0, "");
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load1B59( ) ;
            }
            EndLevel1B59( ) ;
         }
         CloseExtendedTableCursors1B59( ) ;
      }

      protected void Update1B59( )
      {
         BeforeValidate1B59( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1B59( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1B59( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1B59( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1B59( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC001B7 */
                     pr_default.execute(5, new Object[] {A67PacienteId, A244AppointmentStartDate, A242AppointmentEndDate, A243AppointmentObs, A240AppointmentCode});
                     pr_default.close(5);
                     if ( (pr_default.getStatus(5) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Appointment"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate1B59( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), 0, "");
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel1B59( ) ;
         }
         CloseExtendedTableCursors1B59( ) ;
      }

      protected void DeferredUpdate1B59( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         BeforeValidate1B59( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1B59( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1B59( ) ;
            AfterConfirm1B59( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1B59( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC001B8 */
                  pr_default.execute(6, new Object[] {A240AppointmentCode});
                  pr_default.close(6);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), 0, "");
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode59 = Gx_mode ;
         Gx_mode = "DLT" ;
         EndLevel1B59( ) ;
         Gx_mode = sMode59 ;
      }

      protected void OnDeleteControls1B59( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel1B59( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1B59( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanKeyStart1B59( )
      {
         /* Using cursor BC001B9 */
         pr_default.execute(7, new Object[] {A240AppointmentCode});
         RcdFound59 = 0 ;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound59 = 1 ;
            A240AppointmentCode = BC001B9_A240AppointmentCode[0] ;
            A67PacienteId = BC001B9_A67PacienteId[0] ;
            A244AppointmentStartDate = BC001B9_A244AppointmentStartDate[0] ;
            A242AppointmentEndDate = BC001B9_A242AppointmentEndDate[0] ;
            A243AppointmentObs = BC001B9_A243AppointmentObs[0] ;
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext1B59( )
      {
         pr_default.readNext(7);
         RcdFound59 = 0 ;
         ScanKeyLoad1B59( ) ;
      }

      protected void ScanKeyLoad1B59( )
      {
         sMode59 = Gx_mode ;
         Gx_mode = "DSP" ;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound59 = 1 ;
            A240AppointmentCode = BC001B9_A240AppointmentCode[0] ;
            A67PacienteId = BC001B9_A67PacienteId[0] ;
            A244AppointmentStartDate = BC001B9_A244AppointmentStartDate[0] ;
            A242AppointmentEndDate = BC001B9_A242AppointmentEndDate[0] ;
            A243AppointmentObs = BC001B9_A243AppointmentObs[0] ;
         }
         Gx_mode = sMode59 ;
      }

      protected void ScanKeyEnd1B59( )
      {
         pr_default.close(7);
      }

      protected void AfterConfirm1B59( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1B59( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1B59( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1B59( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1B59( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1B59( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1B59( )
      {
      }

      protected void AddRow1B59( )
      {
         VarsToRow59( bcAppointment) ;
      }

      protected void ReadRow1B59( )
      {
         RowToVars59( bcAppointment, 1) ;
      }

      protected void InitializeNonKey1B59( )
      {
         A67PacienteId = 0 ;
         A244AppointmentStartDate = (DateTime)(DateTime.MinValue) ;
         A242AppointmentEndDate = (DateTime)(DateTime.MinValue) ;
         A243AppointmentObs = "" ;
      }

      protected void InitAll1B59( )
      {
         A240AppointmentCode = "" ;
         InitializeNonKey1B59( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow59( SdtAppointment obj59 )
      {
         obj59.gxTpr_Mode = Gx_mode ;
         obj59.gxTpr_Pacienteid = A67PacienteId ;
         obj59.gxTpr_Appointmentstartdate = A244AppointmentStartDate ;
         obj59.gxTpr_Appointmentenddate = A242AppointmentEndDate ;
         obj59.gxTpr_Appointmentobs = A243AppointmentObs ;
         obj59.gxTpr_Appointmentcode = A240AppointmentCode ;
         obj59.gxTpr_Appointmentcode_Z = Z240AppointmentCode ;
         obj59.gxTpr_Pacienteid_Z = Z67PacienteId ;
         obj59.gxTpr_Appointmentstartdate_Z = Z244AppointmentStartDate ;
         obj59.gxTpr_Appointmentenddate_Z = Z242AppointmentEndDate ;
         obj59.gxTpr_Appointmentobs_Z = Z243AppointmentObs ;
         obj59.gxTpr_Mode = Gx_mode ;
         return  ;
      }

      public void RowToVars59( SdtAppointment obj59 ,
                               int forceLoad )
      {
         Gx_mode = obj59.gxTpr_Mode ;
         A67PacienteId = obj59.gxTpr_Pacienteid ;
         A244AppointmentStartDate = obj59.gxTpr_Appointmentstartdate ;
         A242AppointmentEndDate = obj59.gxTpr_Appointmentenddate ;
         A243AppointmentObs = obj59.gxTpr_Appointmentobs ;
         A240AppointmentCode = obj59.gxTpr_Appointmentcode ;
         Z240AppointmentCode = obj59.gxTpr_Appointmentcode_Z ;
         Z67PacienteId = obj59.gxTpr_Pacienteid_Z ;
         Z244AppointmentStartDate = obj59.gxTpr_Appointmentstartdate_Z ;
         Z242AppointmentEndDate = obj59.gxTpr_Appointmentenddate_Z ;
         Z243AppointmentObs = obj59.gxTpr_Appointmentobs_Z ;
         Gx_mode = obj59.gxTpr_Mode ;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         A240AppointmentCode = (String)getParm(obj,0) ;
         AnyError = 0 ;
         context.GX_msglist.removeAllItems();
         InitializeNonKey1B59( ) ;
         ScanKeyStart1B59( ) ;
         if ( RcdFound59 == 0 )
         {
            Gx_mode = "INS" ;
         }
         else
         {
            Gx_mode = "UPD" ;
            Z240AppointmentCode = A240AppointmentCode ;
         }
         ZM1B59( -3) ;
         sMode59 = Gx_mode ;
         Gx_mode = "DSP" ;
         OnLoadActions1B59( ) ;
         Gx_mode = sMode59 ;
         AddRow1B59( ) ;
         ScanKeyEnd1B59( ) ;
         if ( RcdFound59 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1 ;
         }
         context.GX_msglist = BackMsgLst ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         AnyError = 0 ;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1 ;
         RowToVars59( bcAppointment, 0) ;
         nKeyPressed = 1 ;
         GetKey1B59( ) ;
         if ( RcdFound59 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(A240AppointmentCode, Z240AppointmentCode) != 0 )
            {
               A240AppointmentCode = Z240AppointmentCode ;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
            }
            else
            {
               Gx_mode = "UPD" ;
               /* Update record */
               Update1B59( ) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
               AnyError = 1 ;
            }
            else
            {
               if ( StringUtil.StrCmp(A240AppointmentCode, Z240AppointmentCode) != 0 )
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                  }
                  else
                  {
                     Gx_mode = "INS" ;
                     /* Insert record */
                     Insert1B59( ) ;
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                     AnyError = 1 ;
                  }
                  else
                  {
                     Gx_mode = "INS" ;
                     /* Insert record */
                     Insert1B59( ) ;
                  }
               }
            }
         }
         AfterTrn( ) ;
         VarsToRow59( bcAppointment) ;
         context.GX_msglist = BackMsgLst ;
         return  ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         AnyError = 0 ;
         context.GX_msglist.removeAllItems();
         RowToVars59( bcAppointment, 0) ;
         nKeyPressed = 3 ;
         IsConfirmed = 0 ;
         GetKey1B59( ) ;
         if ( RcdFound59 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(A240AppointmentCode, Z240AppointmentCode) != 0 )
            {
               A240AppointmentCode = Z240AppointmentCode ;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1 ;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD" ;
               update_Check( ) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(A240AppointmentCode, Z240AppointmentCode) != 0 )
            {
               Gx_mode = "INS" ;
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1 ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(1);
         context.RollbackDataStores("Appointment_BC");
         VarsToRow59( bcAppointment) ;
         context.GX_msglist = BackMsgLst ;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcAppointment.gxTpr_Mode ;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode ;
         bcAppointment.gxTpr_Mode = Gx_mode ;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcAppointment )
         {
            bcAppointment = (SdtAppointment)(sdt) ;
            if ( StringUtil.StrCmp(bcAppointment.gxTpr_Mode, "") == 0 )
            {
               bcAppointment.gxTpr_Mode = "INS" ;
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow59( bcAppointment) ;
            }
            else
            {
               RowToVars59( bcAppointment, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcAppointment.gxTpr_Mode, "") == 0 )
            {
               bcAppointment.gxTpr_Mode = "INS" ;
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars59( bcAppointment, 1) ;
         return  ;
      }

      public SdtAppointment Appointment_BC
      {
         get {
            return bcAppointment ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
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
         pr_default.close(1);
      }

      public override void initialize( )
      {
         scmdbuf = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Gx_mode = "" ;
         Z240AppointmentCode = "" ;
         A240AppointmentCode = "" ;
         Z244AppointmentStartDate = (DateTime)(DateTime.MinValue) ;
         A244AppointmentStartDate = (DateTime)(DateTime.MinValue) ;
         Z242AppointmentEndDate = (DateTime)(DateTime.MinValue) ;
         A242AppointmentEndDate = (DateTime)(DateTime.MinValue) ;
         Z243AppointmentObs = "" ;
         A243AppointmentObs = "" ;
         BC001B4_A240AppointmentCode = new String[] {""} ;
         BC001B4_A67PacienteId = new int[1] ;
         BC001B4_A244AppointmentStartDate = new DateTime[] {DateTime.MinValue} ;
         BC001B4_A242AppointmentEndDate = new DateTime[] {DateTime.MinValue} ;
         BC001B4_A243AppointmentObs = new String[] {""} ;
         BC001B5_A240AppointmentCode = new String[] {""} ;
         BC001B3_A240AppointmentCode = new String[] {""} ;
         BC001B3_A67PacienteId = new int[1] ;
         BC001B3_A244AppointmentStartDate = new DateTime[] {DateTime.MinValue} ;
         BC001B3_A242AppointmentEndDate = new DateTime[] {DateTime.MinValue} ;
         BC001B3_A243AppointmentObs = new String[] {""} ;
         sMode59 = "" ;
         BC001B2_A240AppointmentCode = new String[] {""} ;
         BC001B2_A67PacienteId = new int[1] ;
         BC001B2_A244AppointmentStartDate = new DateTime[] {DateTime.MinValue} ;
         BC001B2_A242AppointmentEndDate = new DateTime[] {DateTime.MinValue} ;
         BC001B2_A243AppointmentObs = new String[] {""} ;
         BC001B9_A240AppointmentCode = new String[] {""} ;
         BC001B9_A67PacienteId = new int[1] ;
         BC001B9_A244AppointmentStartDate = new DateTime[] {DateTime.MinValue} ;
         BC001B9_A242AppointmentEndDate = new DateTime[] {DateTime.MinValue} ;
         BC001B9_A243AppointmentObs = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.appointment_bc__default(),
            new Object[][] {
                new Object[] {
               BC001B2_A240AppointmentCode, BC001B2_A67PacienteId, BC001B2_A244AppointmentStartDate, BC001B2_A242AppointmentEndDate, BC001B2_A243AppointmentObs
               }
               , new Object[] {
               BC001B3_A240AppointmentCode, BC001B3_A67PacienteId, BC001B3_A244AppointmentStartDate, BC001B3_A242AppointmentEndDate, BC001B3_A243AppointmentObs
               }
               , new Object[] {
               BC001B4_A240AppointmentCode, BC001B4_A67PacienteId, BC001B4_A244AppointmentStartDate, BC001B4_A242AppointmentEndDate, BC001B4_A243AppointmentObs
               }
               , new Object[] {
               BC001B5_A240AppointmentCode
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC001B9_A240AppointmentCode, BC001B9_A67PacienteId, BC001B9_A244AppointmentStartDate, BC001B9_A242AppointmentEndDate, BC001B9_A243AppointmentObs
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: E121B2 */
         E121B2 ();
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short GX_JID ;
      private short RcdFound59 ;
      private int trnEnded ;
      private int Z67PacienteId ;
      private int A67PacienteId ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode59 ;
      private DateTime Z244AppointmentStartDate ;
      private DateTime A244AppointmentStartDate ;
      private DateTime Z242AppointmentEndDate ;
      private DateTime A242AppointmentEndDate ;
      private String Z240AppointmentCode ;
      private String A240AppointmentCode ;
      private String Z243AppointmentObs ;
      private String A243AppointmentObs ;
      private SdtAppointment bcAppointment ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BC001B4_A240AppointmentCode ;
      private int[] BC001B4_A67PacienteId ;
      private DateTime[] BC001B4_A244AppointmentStartDate ;
      private DateTime[] BC001B4_A242AppointmentEndDate ;
      private String[] BC001B4_A243AppointmentObs ;
      private String[] BC001B5_A240AppointmentCode ;
      private String[] BC001B3_A240AppointmentCode ;
      private int[] BC001B3_A67PacienteId ;
      private DateTime[] BC001B3_A244AppointmentStartDate ;
      private DateTime[] BC001B3_A242AppointmentEndDate ;
      private String[] BC001B3_A243AppointmentObs ;
      private String[] BC001B2_A240AppointmentCode ;
      private int[] BC001B2_A67PacienteId ;
      private DateTime[] BC001B2_A244AppointmentStartDate ;
      private DateTime[] BC001B2_A242AppointmentEndDate ;
      private String[] BC001B2_A243AppointmentObs ;
      private String[] BC001B9_A240AppointmentCode ;
      private int[] BC001B9_A67PacienteId ;
      private DateTime[] BC001B9_A244AppointmentStartDate ;
      private DateTime[] BC001B9_A242AppointmentEndDate ;
      private String[] BC001B9_A243AppointmentObs ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class appointment_bc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new UpdateCursor(def[4])
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new ForEachCursor(def[7])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC001B4 ;
          prmBC001B4 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC001B5 ;
          prmBC001B5 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC001B3 ;
          prmBC001B3 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC001B2 ;
          prmBC001B2 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC001B6 ;
          prmBC001B6 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0} ,
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AppointmentStartDate",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AppointmentEndDate",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AppointmentObs",SqlDbType.VarChar,600,0}
          } ;
          Object[] prmBC001B7 ;
          prmBC001B7 = new Object[] {
          new Object[] {"@PacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AppointmentStartDate",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AppointmentEndDate",SqlDbType.DateTime,8,5} ,
          new Object[] {"@AppointmentObs",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC001B8 ;
          prmBC001B8 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmBC001B9 ;
          prmBC001B9 = new Object[] {
          new Object[] {"@AppointmentCode",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC001B2", "SELECT [AppointmentCode], [PacienteId], [AppointmentStartDate], [AppointmentEndDate], [AppointmentObs] FROM [Appointment] WITH (UPDLOCK) WHERE [AppointmentCode] = @AppointmentCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B2,1,0,true,false )
             ,new CursorDef("BC001B3", "SELECT [AppointmentCode], [PacienteId], [AppointmentStartDate], [AppointmentEndDate], [AppointmentObs] FROM [Appointment] WITH (NOLOCK) WHERE [AppointmentCode] = @AppointmentCode ",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B3,1,0,true,false )
             ,new CursorDef("BC001B4", "SELECT TM1.[AppointmentCode], TM1.[PacienteId], TM1.[AppointmentStartDate], TM1.[AppointmentEndDate], TM1.[AppointmentObs] FROM [Appointment] TM1 WITH (NOLOCK) WHERE TM1.[AppointmentCode] = @AppointmentCode ORDER BY TM1.[AppointmentCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B4,100,0,true,false )
             ,new CursorDef("BC001B5", "SELECT [AppointmentCode] FROM [Appointment] WITH (NOLOCK) WHERE [AppointmentCode] = @AppointmentCode  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B5,1,0,true,false )
             ,new CursorDef("BC001B6", "INSERT INTO [Appointment] ([AppointmentCode], [PacienteId], [AppointmentStartDate], [AppointmentEndDate], [AppointmentObs]) VALUES (@AppointmentCode, @PacienteId, @AppointmentStartDate, @AppointmentEndDate, @AppointmentObs)", GxErrorMask.GX_NOMASK,prmBC001B6)
             ,new CursorDef("BC001B7", "UPDATE [Appointment] SET [PacienteId]=@PacienteId, [AppointmentStartDate]=@AppointmentStartDate, [AppointmentEndDate]=@AppointmentEndDate, [AppointmentObs]=@AppointmentObs  WHERE [AppointmentCode] = @AppointmentCode", GxErrorMask.GX_NOMASK,prmBC001B7)
             ,new CursorDef("BC001B8", "DELETE FROM [Appointment]  WHERE [AppointmentCode] = @AppointmentCode", GxErrorMask.GX_NOMASK,prmBC001B8)
             ,new CursorDef("BC001B9", "SELECT TM1.[AppointmentCode], TM1.[PacienteId], TM1.[AppointmentStartDate], TM1.[AppointmentEndDate], TM1.[AppointmentObs] FROM [Appointment] TM1 WITH (NOLOCK) WHERE TM1.[AppointmentCode] = @AppointmentCode ORDER BY TM1.[AppointmentCode]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC001B9,100,0,true,false )
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
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
             case 5 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                break;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
