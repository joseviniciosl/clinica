/*
               File: MedicoEspConversion
        Description: Conversion for table MedicoEsp
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:25.46
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class medicoespconversion : GXProcedure
   {
      public medicoespconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public medicoespconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         medicoespconversion objmedicoespconversion;
         objmedicoespconversion = new medicoespconversion();
         objmedicoespconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objmedicoespconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((medicoespconversion)stateInfo).executePrivate();
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
         /* Using cursor MEDICOESPC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A17EspCodigo = MEDICOESPC2_A17EspCodigo[0] ;
            A19MedicoCodigo = MEDICOESPC2_A19MedicoCodigo[0] ;
            A41ClinicaCodigo = MEDICOESPC2_A41ClinicaCodigo[0] ;
            A40000GXC1 = MEDICOESPC2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0032

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3MedicoCodigo = A19MedicoCodigo ;
            AV4EspCodigo = A17EspCodigo ;
            /* Using cursor MEDICOESPC3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3MedicoCodigo, AV4EspCodigo});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
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
         scmdbuf = "" ;
         MEDICOESPC2_A17EspCodigo = new String[] {""} ;
         MEDICOESPC2_A19MedicoCodigo = new String[] {""} ;
         MEDICOESPC2_A41ClinicaCodigo = new String[] {""} ;
         MEDICOESPC2_A40000GXC1 = new int[1] ;
         A17EspCodigo = "" ;
         A19MedicoCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3MedicoCodigo = "" ;
         AV4EspCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.medicoespconversion__default(),
            new Object[][] {
                new Object[] {
               MEDICOESPC2_A17EspCodigo, MEDICOESPC2_A19MedicoCodigo, MEDICOESPC2_A41ClinicaCodigo, MEDICOESPC2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A40000GXC1 ;
      private int GIGXA0032 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A17EspCodigo ;
      private String A19MedicoCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3MedicoCodigo ;
      private String AV4EspCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] MEDICOESPC2_A17EspCodigo ;
      private String[] MEDICOESPC2_A19MedicoCodigo ;
      private String[] MEDICOESPC2_A41ClinicaCodigo ;
      private int[] MEDICOESPC2_A40000GXC1 ;
   }

   public class medicoespconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmMEDICOESPC2 ;
          prmMEDICOESPC2 = new Object[] {
          } ;
          Object[] prmMEDICOESPC3 ;
          prmMEDICOESPC3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3MedicoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4EspCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("MEDICOESPC2", "SELECT [EspCodigo], [MedicoCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [MedicoEsp] ORDER BY [ClinicaCodigo], [MedicoCodigo], [EspCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmMEDICOESPC2,100,0,true,false )
             ,new CursorDef("MEDICOESPC3", "INSERT INTO [GXA0032] ([ClinicaCodigo], [MedicoCodigo], [EspCodigo]) VALUES (@AV2ClinicaCodigo, @AV3MedicoCodigo, @AV4EspCodigo)", GxErrorMask.GX_NOMASK,prmMEDICOESPC3)
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
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
       }
    }

 }

}
