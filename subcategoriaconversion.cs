/*
               File: SubCategoriaConversion
        Description: Conversion for table SubCategoria
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.12
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
   public class subcategoriaconversion : GXProcedure
   {
      public subcategoriaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public subcategoriaconversion( IGxContext context )
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
         subcategoriaconversion objsubcategoriaconversion;
         objsubcategoriaconversion = new subcategoriaconversion();
         objsubcategoriaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objsubcategoriaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((subcategoriaconversion)stateInfo).executePrivate();
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
         /* Using cursor SUBCATEGOR2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A125SubCategoriaDescripcion = SUBCATEGOR2_A125SubCategoriaDescripcion[0] ;
            A124SubCategoriaCodigo = SUBCATEGOR2_A124SubCategoriaCodigo[0] ;
            A27CategoriaCodigo = SUBCATEGOR2_A27CategoriaCodigo[0] ;
            A41ClinicaCodigo = SUBCATEGOR2_A41ClinicaCodigo[0] ;
            A40000GXC1 = SUBCATEGOR2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0011

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CategoriaCodigo = A27CategoriaCodigo ;
            AV4SubCategoriaCodigo = A124SubCategoriaCodigo ;
            AV5SubCategoriaDescripcion = A125SubCategoriaDescripcion ;
            /* Using cursor SUBCATEGOR3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CategoriaCodigo, AV4SubCategoriaCodigo, AV5SubCategoriaDescripcion});
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
         SUBCATEGOR2_A125SubCategoriaDescripcion = new String[] {""} ;
         SUBCATEGOR2_A124SubCategoriaCodigo = new String[] {""} ;
         SUBCATEGOR2_A27CategoriaCodigo = new String[] {""} ;
         SUBCATEGOR2_A41ClinicaCodigo = new String[] {""} ;
         SUBCATEGOR2_A40000GXC1 = new int[1] ;
         A125SubCategoriaDescripcion = "" ;
         A124SubCategoriaCodigo = "" ;
         A27CategoriaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3CategoriaCodigo = "" ;
         AV4SubCategoriaCodigo = "" ;
         AV5SubCategoriaDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.subcategoriaconversion__default(),
            new Object[][] {
                new Object[] {
               SUBCATEGOR2_A125SubCategoriaDescripcion, SUBCATEGOR2_A124SubCategoriaCodigo, SUBCATEGOR2_A27CategoriaCodigo, SUBCATEGOR2_A41ClinicaCodigo, SUBCATEGOR2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int A40000GXC1 ;
      private int GIGXA0011 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A125SubCategoriaDescripcion ;
      private String A124SubCategoriaCodigo ;
      private String A27CategoriaCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3CategoriaCodigo ;
      private String AV4SubCategoriaCodigo ;
      private String AV5SubCategoriaDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] SUBCATEGOR2_A125SubCategoriaDescripcion ;
      private String[] SUBCATEGOR2_A124SubCategoriaCodigo ;
      private String[] SUBCATEGOR2_A27CategoriaCodigo ;
      private String[] SUBCATEGOR2_A41ClinicaCodigo ;
      private int[] SUBCATEGOR2_A40000GXC1 ;
   }

   public class subcategoriaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmSUBCATEGOR2 ;
          prmSUBCATEGOR2 = new Object[] {
          } ;
          Object[] prmSUBCATEGOR3 ;
          prmSUBCATEGOR3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4SubCategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV5SubCategoriaDescripcion",SqlDbType.VarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("SUBCATEGOR2", "SELECT [SubCategoriaDescripcion], [SubCategoriaCodigo], [CategoriaCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [SubCategoria] ORDER BY [ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmSUBCATEGOR2,100,0,true,false )
             ,new CursorDef("SUBCATEGOR3", "INSERT INTO [GXA0011] ([ClinicaCodigo], [CategoriaCodigo], [SubCategoriaCodigo], [SubCategoriaDescripcion]) VALUES (@AV2ClinicaCodigo, @AV3CategoriaCodigo, @AV4SubCategoriaCodigo, @AV5SubCategoriaDescripcion)", GxErrorMask.GX_NOMASK,prmSUBCATEGOR3)
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
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
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
                stmt.SetParameter(4, (String)parms[3]);
                break;
       }
    }

 }

}
