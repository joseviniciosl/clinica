/*
               File: TipoAdmisionConversion
        Description: Conversion for table TipoAdmision
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.20
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
   public class tipoadmisionconversion : GXProcedure
   {
      public tipoadmisionconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tipoadmisionconversion( IGxContext context )
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
         tipoadmisionconversion objtipoadmisionconversion;
         objtipoadmisionconversion = new tipoadmisionconversion();
         objtipoadmisionconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objtipoadmisionconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipoadmisionconversion)stateInfo).executePrivate();
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
         /* Using cursor TIPOADMISI2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A149TipoAdmEstado = TIPOADMISI2_A149TipoAdmEstado[0] ;
            A148TipoAdmDescripcion = TIPOADMISI2_A148TipoAdmDescripcion[0] ;
            A147TipoAdmCodigo = TIPOADMISI2_A147TipoAdmCodigo[0] ;
            A41ClinicaCodigo = TIPOADMISI2_A41ClinicaCodigo[0] ;
            A40000GXC1 = TIPOADMISI2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0041

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoAdmCodigo = A147TipoAdmCodigo ;
            AV4TipoAdmDescripcion = A148TipoAdmDescripcion ;
            AV5TipoAdmEstado = A149TipoAdmEstado ;
            /* Using cursor TIPOADMISI3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoAdmCodigo, AV4TipoAdmDescripcion, AV5TipoAdmEstado});
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
         TIPOADMISI2_A149TipoAdmEstado = new short[1] ;
         TIPOADMISI2_A148TipoAdmDescripcion = new String[] {""} ;
         TIPOADMISI2_A147TipoAdmCodigo = new String[] {""} ;
         TIPOADMISI2_A41ClinicaCodigo = new String[] {""} ;
         TIPOADMISI2_A40000GXC1 = new int[1] ;
         A148TipoAdmDescripcion = "" ;
         A147TipoAdmCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoAdmCodigo = "" ;
         AV4TipoAdmDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipoadmisionconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOADMISI2_A149TipoAdmEstado, TIPOADMISI2_A148TipoAdmDescripcion, TIPOADMISI2_A147TipoAdmCodigo, TIPOADMISI2_A41ClinicaCodigo, TIPOADMISI2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A149TipoAdmEstado ;
      private short AV5TipoAdmEstado ;
      private int A40000GXC1 ;
      private int GIGXA0041 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A148TipoAdmDescripcion ;
      private String A147TipoAdmCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoAdmCodigo ;
      private String AV4TipoAdmDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] TIPOADMISI2_A149TipoAdmEstado ;
      private String[] TIPOADMISI2_A148TipoAdmDescripcion ;
      private String[] TIPOADMISI2_A147TipoAdmCodigo ;
      private String[] TIPOADMISI2_A41ClinicaCodigo ;
      private int[] TIPOADMISI2_A40000GXC1 ;
   }

   public class tipoadmisionconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmTIPOADMISI2 ;
          prmTIPOADMISI2 = new Object[] {
          } ;
          Object[] prmTIPOADMISI3 ;
          prmTIPOADMISI3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoAdmCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4TipoAdmDescripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5TipoAdmEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOADMISI2", "SELECT [TipoAdmEstado], [TipoAdmDescripcion], [TipoAdmCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [TipoAdmision] ORDER BY [ClinicaCodigo], [TipoAdmCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOADMISI2,100,0,true,false )
             ,new CursorDef("TIPOADMISI3", "INSERT INTO [GXA0041] ([ClinicaCodigo], [TipoAdmCodigo], [TipoAdmDescripcion], [TipoAdmEstado]) VALUES (@AV2ClinicaCodigo, @AV3TipoAdmCodigo, @AV4TipoAdmDescripcion, @AV5TipoAdmEstado)", GxErrorMask.GX_NOMASK,prmTIPOADMISI3)
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
