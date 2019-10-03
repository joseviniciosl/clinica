/*
               File: Cie10Conversion
        Description: Conversion for table Cie10
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.72
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
   public class cie10conversion : GXProcedure
   {
      public cie10conversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cie10conversion( IGxContext context )
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
         cie10conversion objcie10conversion;
         objcie10conversion = new cie10conversion();
         objcie10conversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcie10conversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cie10conversion)stateInfo).executePrivate();
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
         /* Using cursor CIE10CONVE2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A51Cie10Descripcion = CIE10CONVE2_A51Cie10Descripcion[0] ;
            A50Cie10Codigo = CIE10CONVE2_A50Cie10Codigo[0] ;
            A41ClinicaCodigo = CIE10CONVE2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CIE10CONVE2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0017

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3Cie10Codigo = A50Cie10Codigo ;
            AV4Cie10Descripcion = A51Cie10Descripcion ;
            /* Using cursor CIE10CONVE3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3Cie10Codigo, AV4Cie10Descripcion});
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
         CIE10CONVE2_A51Cie10Descripcion = new String[] {""} ;
         CIE10CONVE2_A50Cie10Codigo = new String[] {""} ;
         CIE10CONVE2_A41ClinicaCodigo = new String[] {""} ;
         CIE10CONVE2_A40000GXC1 = new int[1] ;
         A51Cie10Descripcion = "" ;
         A50Cie10Codigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3Cie10Codigo = "" ;
         AV4Cie10Descripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cie10conversion__default(),
            new Object[][] {
                new Object[] {
               CIE10CONVE2_A51Cie10Descripcion, CIE10CONVE2_A50Cie10Codigo, CIE10CONVE2_A41ClinicaCodigo, CIE10CONVE2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A40000GXC1 ;
      private int GIGXA0017 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A51Cie10Descripcion ;
      private String A50Cie10Codigo ;
      private String A41ClinicaCodigo ;
      private String AV3Cie10Codigo ;
      private String AV4Cie10Descripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] CIE10CONVE2_A51Cie10Descripcion ;
      private String[] CIE10CONVE2_A50Cie10Codigo ;
      private String[] CIE10CONVE2_A41ClinicaCodigo ;
      private int[] CIE10CONVE2_A40000GXC1 ;
   }

   public class cie10conversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCIE10CONVE2 ;
          prmCIE10CONVE2 = new Object[] {
          } ;
          Object[] prmCIE10CONVE3 ;
          prmCIE10CONVE3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3Cie10Codigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4Cie10Descripcion",SqlDbType.VarChar,1000,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CIE10CONVE2", "SELECT [Cie10Descripcion], [Cie10Codigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Cie10] ORDER BY [ClinicaCodigo], [Cie10Codigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCIE10CONVE2,100,0,true,false )
             ,new CursorDef("CIE10CONVE3", "INSERT INTO [GXA0017] ([ClinicaCodigo], [Cie10Codigo], [Cie10Descripcion]) VALUES (@AV2ClinicaCodigo, @AV3Cie10Codigo, @AV4Cie10Descripcion)", GxErrorMask.GX_NOMASK,prmCIE10CONVE3)
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
