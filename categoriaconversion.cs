/*
               File: CategoriaConversion
        Description: Conversion for table Categoria
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.63
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
   public class categoriaconversion : GXProcedure
   {
      public categoriaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public categoriaconversion( IGxContext context )
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
         categoriaconversion objcategoriaconversion;
         objcategoriaconversion = new categoriaconversion();
         objcategoriaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcategoriaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((categoriaconversion)stateInfo).executePrivate();
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
         /* Using cursor CATEGORIAC2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A29CategoriaEstado = CATEGORIAC2_A29CategoriaEstado[0] ;
            A28CategoriaDescripcion = CATEGORIAC2_A28CategoriaDescripcion[0] ;
            A27CategoriaCodigo = CATEGORIAC2_A27CategoriaCodigo[0] ;
            A41ClinicaCodigo = CATEGORIAC2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CATEGORIAC2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0010

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CategoriaCodigo = A27CategoriaCodigo ;
            AV4CategoriaDescripcion = A28CategoriaDescripcion ;
            AV5CategoriaEstado = A29CategoriaEstado ;
            /* Using cursor CATEGORIAC3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CategoriaCodigo, AV4CategoriaDescripcion, AV5CategoriaEstado});
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
         CATEGORIAC2_A29CategoriaEstado = new short[1] ;
         CATEGORIAC2_A28CategoriaDescripcion = new String[] {""} ;
         CATEGORIAC2_A27CategoriaCodigo = new String[] {""} ;
         CATEGORIAC2_A41ClinicaCodigo = new String[] {""} ;
         CATEGORIAC2_A40000GXC1 = new int[1] ;
         A28CategoriaDescripcion = "" ;
         A27CategoriaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3CategoriaCodigo = "" ;
         AV4CategoriaDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.categoriaconversion__default(),
            new Object[][] {
                new Object[] {
               CATEGORIAC2_A29CategoriaEstado, CATEGORIAC2_A28CategoriaDescripcion, CATEGORIAC2_A27CategoriaCodigo, CATEGORIAC2_A41ClinicaCodigo, CATEGORIAC2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A29CategoriaEstado ;
      private short AV5CategoriaEstado ;
      private int A40000GXC1 ;
      private int GIGXA0010 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A28CategoriaDescripcion ;
      private String A27CategoriaCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3CategoriaCodigo ;
      private String AV4CategoriaDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] CATEGORIAC2_A29CategoriaEstado ;
      private String[] CATEGORIAC2_A28CategoriaDescripcion ;
      private String[] CATEGORIAC2_A27CategoriaCodigo ;
      private String[] CATEGORIAC2_A41ClinicaCodigo ;
      private int[] CATEGORIAC2_A40000GXC1 ;
   }

   public class categoriaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCATEGORIAC2 ;
          prmCATEGORIAC2 = new Object[] {
          } ;
          Object[] prmCATEGORIAC3 ;
          prmCATEGORIAC3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CategoriaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4CategoriaDescripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5CategoriaEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CATEGORIAC2", "SELECT [CategoriaEstado], [CategoriaDescripcion], [CategoriaCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Categoria] ORDER BY [ClinicaCodigo], [CategoriaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCATEGORIAC2,100,0,true,false )
             ,new CursorDef("CATEGORIAC3", "INSERT INTO [GXA0010] ([ClinicaCodigo], [CategoriaCodigo], [CategoriaDescripcion], [CategoriaEstado]) VALUES (@AV2ClinicaCodigo, @AV3CategoriaCodigo, @AV4CategoriaDescripcion, @AV5CategoriaEstado)", GxErrorMask.GX_NOMASK,prmCATEGORIAC3)
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
                stmt.SetParameter(4, (short)parms[3]);
                break;
       }
    }

 }

}
