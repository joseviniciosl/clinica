/*
               File: BancoConversion
        Description: Conversion for table Banco
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.28
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
   public class bancoconversion : GXProcedure
   {
      public bancoconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public bancoconversion( IGxContext context )
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
         bancoconversion objbancoconversion;
         objbancoconversion = new bancoconversion();
         objbancoconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objbancoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((bancoconversion)stateInfo).executePrivate();
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
         /* Using cursor BANCOCONVE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A127BancoDescripcion = BANCOCONVE2_A127BancoDescripcion[0] ;
            A126BancoCodigo = BANCOCONVE2_A126BancoCodigo[0] ;
            A41ClinicaCodigo = BANCOCONVE2_A41ClinicaCodigo[0] ;
            A40000GXC1 = BANCOCONVE2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0034

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3BancoCodigo = A126BancoCodigo ;
            AV4BancoDescripcion = A127BancoDescripcion ;
            /* Using cursor BANCOCONVE3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3BancoCodigo, AV4BancoDescripcion});
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
         BANCOCONVE2_A127BancoDescripcion = new String[] {""} ;
         BANCOCONVE2_A126BancoCodigo = new String[] {""} ;
         BANCOCONVE2_A41ClinicaCodigo = new String[] {""} ;
         BANCOCONVE2_A40000GXC1 = new int[1] ;
         A127BancoDescripcion = "" ;
         A126BancoCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3BancoCodigo = "" ;
         AV4BancoDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bancoconversion__default(),
            new Object[][] {
                new Object[] {
               BANCOCONVE2_A127BancoDescripcion, BANCOCONVE2_A126BancoCodigo, BANCOCONVE2_A41ClinicaCodigo, BANCOCONVE2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A40000GXC1 ;
      private int GIGXA0034 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A127BancoDescripcion ;
      private String A126BancoCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3BancoCodigo ;
      private String AV4BancoDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] BANCOCONVE2_A127BancoDescripcion ;
      private String[] BANCOCONVE2_A126BancoCodigo ;
      private String[] BANCOCONVE2_A41ClinicaCodigo ;
      private int[] BANCOCONVE2_A40000GXC1 ;
   }

   public class bancoconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBANCOCONVE2 ;
          prmBANCOCONVE2 = new Object[] {
          } ;
          Object[] prmBANCOCONVE3 ;
          prmBANCOCONVE3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3BancoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4BancoDescripcion",SqlDbType.VarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BANCOCONVE2", "SELECT [BancoDescripcion], [BancoCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Banco] ORDER BY [ClinicaCodigo], [BancoCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmBANCOCONVE2,100,0,true,false )
             ,new CursorDef("BANCOCONVE3", "INSERT INTO [GXA0034] ([ClinicaCodigo], [BancoCodigo], [BancoDescripcion]) VALUES (@AV2ClinicaCodigo, @AV3BancoCodigo, @AV4BancoDescripcion)", GxErrorMask.GX_NOMASK,prmBANCOCONVE3)
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
