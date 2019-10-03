/*
               File: oObtieneArticulo
        Description: Obtiene Precio de venta de Articulo
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:37.78
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class oobtienearticulo : GXProcedure
   {
      public oobtienearticulo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public oobtienearticulo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_ClinicaCodigo ,
                           String aP1_ArticuloCodigo ,
                           out decimal aP2_ArticuloPrecio )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A30ArticuloCodigo = aP1_ArticuloCodigo;
         this.AV8ArticuloPrecio = 0 ;
         initialize();
         executePrivate();
         aP2_ArticuloPrecio=this.AV8ArticuloPrecio;
      }

      public decimal executeUdp( String aP0_ClinicaCodigo ,
                                 String aP1_ArticuloCodigo )
      {
         this.A41ClinicaCodigo = aP0_ClinicaCodigo;
         this.A30ArticuloCodigo = aP1_ArticuloCodigo;
         this.AV8ArticuloPrecio = 0 ;
         initialize();
         executePrivate();
         aP2_ArticuloPrecio=this.AV8ArticuloPrecio;
         return AV8ArticuloPrecio ;
      }

      public void executeSubmit( String aP0_ClinicaCodigo ,
                                 String aP1_ArticuloCodigo ,
                                 out decimal aP2_ArticuloPrecio )
      {
         oobtienearticulo objoobtienearticulo;
         objoobtienearticulo = new oobtienearticulo();
         objoobtienearticulo.A41ClinicaCodigo = aP0_ClinicaCodigo;
         objoobtienearticulo.A30ArticuloCodigo = aP1_ArticuloCodigo;
         objoobtienearticulo.AV8ArticuloPrecio = 0 ;
         objoobtienearticulo.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objoobtienearticulo);
         aP2_ArticuloPrecio=this.AV8ArticuloPrecio;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((oobtienearticulo)stateInfo).executePrivate();
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
         /* Using cursor P000A2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A30ArticuloCodigo});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A32ArticuloPrecio = P000A2_A32ArticuloPrecio[0] ;
            AV8ArticuloPrecio = A32ArticuloPrecio ;
            /* Exiting from a For First loop. */
            if (true) break;
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
         P000A2_A41ClinicaCodigo = new String[] {""} ;
         P000A2_A30ArticuloCodigo = new String[] {""} ;
         P000A2_A32ArticuloPrecio = new decimal[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.oobtienearticulo__default(),
            new Object[][] {
                new Object[] {
               P000A2_A41ClinicaCodigo, P000A2_A30ArticuloCodigo, P000A2_A32ArticuloPrecio
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private decimal AV8ArticuloPrecio ;
      private decimal A32ArticuloPrecio ;
      private String scmdbuf ;
      private String A41ClinicaCodigo ;
      private String A30ArticuloCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P000A2_A41ClinicaCodigo ;
      private String[] P000A2_A30ArticuloCodigo ;
      private decimal[] P000A2_A32ArticuloPrecio ;
      private decimal aP2_ArticuloPrecio ;
   }

   public class oobtienearticulo__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000A2 ;
          prmP000A2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@ArticuloCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000A2", "SELECT [ClinicaCodigo], [ArticuloCodigo], [ArticuloPrecio] FROM [Articulo] WITH (NOLOCK) WHERE [ClinicaCodigo] = @ClinicaCodigo and [ArticuloCodigo] = @ArticuloCodigo ORDER BY [ClinicaCodigo], [ArticuloCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000A2,1,0,false,true )
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
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
