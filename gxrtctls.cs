/*
               File: GXRTCtls
        Description: Run time reorganization controls
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 9/9/2019 11:57:39.46
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
   public class gxrtctls : GXProcedure
   {
      public gxrtctls( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public gxrtctls( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out short aP0_Status )
      {
         this.AV2Status = 0 ;
         initialize();
         executePrivate();
         aP0_Status=this.AV2Status;
      }

      public short executeUdp( )
      {
         this.AV2Status = 0 ;
         initialize();
         executePrivate();
         aP0_Status=this.AV2Status;
         return AV2Status ;
      }

      public void executeSubmit( out short aP0_Status )
      {
         gxrtctls objgxrtctls;
         objgxrtctls = new gxrtctls();
         objgxrtctls.AV2Status = 0 ;
         objgxrtctls.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objgxrtctls);
         aP0_Status=this.AV2Status;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((gxrtctls)stateInfo).executePrivate();
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
         AV2Status = 0 ;
         Console.WriteLine( "=== Starting run time controls" );
         Console.WriteLine( "Checking that table Vendedor does NOT contain records." );
         AV3NotFound = 0 ;
         AV6GXLvl4 = 0 ;
         /* Using cursor LTCTLS2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A41ClinicaCodigo = LTCTLS2_A41ClinicaCodigo[0] ;
            AV6GXLvl4 = 1 ;
            AV7GXLvl7 = 0 ;
            /* Using cursor LTCTLS3 */
            pr_default.execute(1, new Object[] {A41ClinicaCodigo});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A370TipoVendedorId = LTCTLS3_A370TipoVendedorId[0] ;
               AV7GXLvl7 = 1 ;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            if ( AV7GXLvl7 == 0 )
            {
               AV2Status = 1 ;
               Console.WriteLine( "Fail: Table Vendedor has records but referenced key value in table TipoVendedor does _not_ exist." );
               Console.WriteLine( "Recovery: See recovery information for reorganization message rgz0029." );
               AV3NotFound = 1 ;
            }
            if ( AV3NotFound == 1 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV6GXLvl4 == 0 )
         {
            Console.WriteLine( "Success: Table Vendedor does NOT have records." );
            AV3NotFound = 1 ;
         }
         if ( AV3NotFound == 0 )
         {
            Console.WriteLine( "Success: Table Vendedorhas records but all referenced key values in table TipoVendedor exist." );
         }
         Console.WriteLine( "====================" );
         Console.WriteLine( "=== End of run time controls" );
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
         LTCTLS2_A41ClinicaCodigo = new String[] {""} ;
         A41ClinicaCodigo = "" ;
         LTCTLS3_A41ClinicaCodigo = new String[] {""} ;
         LTCTLS3_A370TipoVendedorId = new int[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gxrtctls__default(),
            new Object[][] {
                new Object[] {
               LTCTLS2_A41ClinicaCodigo
               }
               , new Object[] {
               LTCTLS3_A41ClinicaCodigo, LTCTLS3_A370TipoVendedorId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV2Status ;
      private short AV3NotFound ;
      private short AV6GXLvl4 ;
      private short AV7GXLvl7 ;
      private int A370TipoVendedorId ;
      private String scmdbuf ;
      private String A41ClinicaCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] LTCTLS2_A41ClinicaCodigo ;
      private String[] LTCTLS3_A41ClinicaCodigo ;
      private int[] LTCTLS3_A370TipoVendedorId ;
      private short aP0_Status ;
   }

   public class gxrtctls__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmLTCTLS2 ;
          prmLTCTLS2 = new Object[] {
          } ;
          Object[] prmLTCTLS3 ;
          prmLTCTLS3 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("LTCTLS2", "SELECT DISTINCT [ClinicaCodigo] FROM [Vendedor] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmLTCTLS2,100,0,true,false )
             ,new CursorDef("LTCTLS3", "SELECT [ClinicaCodigo], [TipoVendedorId] FROM [TipoVendedor] WHERE ([ClinicaCodigo] = @ClinicaCodigo) AND ([TipoVendedorId] = 0) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmLTCTLS3,100,0,false,false )
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
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
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
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
