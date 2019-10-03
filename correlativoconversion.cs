/*
               File: CorrelativoConversion
        Description: Conversion for table Correlativo
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:24.42
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
   public class correlativoconversion : GXProcedure
   {
      public correlativoconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public correlativoconversion( IGxContext context )
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
         correlativoconversion objcorrelativoconversion;
         objcorrelativoconversion = new correlativoconversion();
         objcorrelativoconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcorrelativoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((correlativoconversion)stateInfo).executePrivate();
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
         /* Using cursor CORRELATIV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A62CorrelativoDescripcion = CORRELATIV2_A62CorrelativoDescripcion[0] ;
            A61CorrelativoId = CORRELATIV2_A61CorrelativoId[0] ;
            A41ClinicaCodigo = CORRELATIV2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CORRELATIV2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0020

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CorrelativoId = A61CorrelativoId ;
            AV4CorrelativoDescripcion = A62CorrelativoDescripcion ;
            /* Using cursor CORRELATIV3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CorrelativoId, AV4CorrelativoDescripcion});
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
         CORRELATIV2_A62CorrelativoDescripcion = new String[] {""} ;
         CORRELATIV2_A61CorrelativoId = new int[1] ;
         CORRELATIV2_A41ClinicaCodigo = new String[] {""} ;
         CORRELATIV2_A40000GXC1 = new int[1] ;
         A62CorrelativoDescripcion = "" ;
         A41ClinicaCodigo = "" ;
         AV4CorrelativoDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.correlativoconversion__default(),
            new Object[][] {
                new Object[] {
               CORRELATIV2_A62CorrelativoDescripcion, CORRELATIV2_A61CorrelativoId, CORRELATIV2_A41ClinicaCodigo, CORRELATIV2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A61CorrelativoId ;
      private int A40000GXC1 ;
      private int GIGXA0020 ;
      private int AV2ClinicaCodigo ;
      private int AV3CorrelativoId ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A62CorrelativoDescripcion ;
      private String A41ClinicaCodigo ;
      private String AV4CorrelativoDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] CORRELATIV2_A62CorrelativoDescripcion ;
      private int[] CORRELATIV2_A61CorrelativoId ;
      private String[] CORRELATIV2_A41ClinicaCodigo ;
      private int[] CORRELATIV2_A40000GXC1 ;
   }

   public class correlativoconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCORRELATIV2 ;
          prmCORRELATIV2 = new Object[] {
          } ;
          Object[] prmCORRELATIV3 ;
          prmCORRELATIV3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4CorrelativoDescripcion",SqlDbType.VarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CORRELATIV2", "SELECT [CorrelativoDescripcion], [CorrelativoId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Correlativo] ORDER BY [ClinicaCodigo], [CorrelativoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCORRELATIV2,100,0,true,false )
             ,new CursorDef("CORRELATIV3", "INSERT INTO [GXA0020] ([ClinicaCodigo], [CorrelativoId], [CorrelativoDescripcion]) VALUES (@AV2ClinicaCodigo, @AV3CorrelativoId, @AV4CorrelativoDescripcion)", GxErrorMask.GX_NOMASK,prmCORRELATIV3)
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                break;
       }
    }

 }

}
