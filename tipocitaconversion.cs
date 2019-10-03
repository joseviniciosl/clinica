/*
               File: TipoCitaConversion
        Description: Conversion for table TipoCita
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.30
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
   public class tipocitaconversion : GXProcedure
   {
      public tipocitaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tipocitaconversion( IGxContext context )
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
         tipocitaconversion objtipocitaconversion;
         objtipocitaconversion = new tipocitaconversion();
         objtipocitaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objtipocitaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipocitaconversion)stateInfo).executePrivate();
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
         /* Using cursor TIPOCITACO2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A55CitaNombre = TIPOCITACO2_A55CitaNombre[0] ;
            A54CitaCodigo = TIPOCITACO2_A54CitaCodigo[0] ;
            A41ClinicaCodigo = TIPOCITACO2_A41ClinicaCodigo[0] ;
            A40000GXC1 = TIPOCITACO2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0018

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CitaCodigo = A54CitaCodigo ;
            AV4CitaNombre = A55CitaNombre ;
            /* Using cursor TIPOCITACO3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CitaCodigo, AV4CitaNombre});
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
         TIPOCITACO2_A55CitaNombre = new String[] {""} ;
         TIPOCITACO2_A54CitaCodigo = new String[] {""} ;
         TIPOCITACO2_A41ClinicaCodigo = new String[] {""} ;
         TIPOCITACO2_A40000GXC1 = new int[1] ;
         A55CitaNombre = "" ;
         A54CitaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3CitaCodigo = "" ;
         AV4CitaNombre = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipocitaconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOCITACO2_A55CitaNombre, TIPOCITACO2_A54CitaCodigo, TIPOCITACO2_A41ClinicaCodigo, TIPOCITACO2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A40000GXC1 ;
      private int GIGXA0018 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A55CitaNombre ;
      private String A54CitaCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3CitaCodigo ;
      private String AV4CitaNombre ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] TIPOCITACO2_A55CitaNombre ;
      private String[] TIPOCITACO2_A54CitaCodigo ;
      private String[] TIPOCITACO2_A41ClinicaCodigo ;
      private int[] TIPOCITACO2_A40000GXC1 ;
   }

   public class tipocitaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmTIPOCITACO2 ;
          prmTIPOCITACO2 = new Object[] {
          } ;
          Object[] prmTIPOCITACO3 ;
          prmTIPOCITACO3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CitaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4CitaNombre",SqlDbType.VarChar,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOCITACO2", "SELECT [CitaNombre], [CitaCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [TipoCita] ORDER BY [ClinicaCodigo], [CitaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOCITACO2,100,0,true,false )
             ,new CursorDef("TIPOCITACO3", "INSERT INTO [GXA0018] ([ClinicaCodigo], [CitaCodigo], [CitaNombre]) VALUES (@AV2ClinicaCodigo, @AV3CitaCodigo, @AV4CitaNombre)", GxErrorMask.GX_NOMASK,prmTIPOCITACO3)
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
