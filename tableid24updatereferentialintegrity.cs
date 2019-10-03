/*
               File: TableId24UpdateReferentialIntegrity
        Description: Load referential integrity
             Author: GeneXus C# Generator version 10_1_1-28290
       Generated on: 3/1/2019 9:46:8.46
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
   public class tableid24updatereferentialintegrity : GXProcedure
   {
      public tableid24updatereferentialintegrity( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tableid24updatereferentialintegrity( IGxContext context )
      {
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
         tableid24updatereferentialintegrity objtableid24updatereferentialintegrity;
         objtableid24updatereferentialintegrity = new tableid24updatereferentialintegrity();
         objtableid24updatereferentialintegrity.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objtableid24updatereferentialintegrity.executePrivateCatch ));
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
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
         /* Using cursor TABLEID24U2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A82AsegCodigo = TABLEID24U2_A82AsegCodigo[0] ;
            A41ClinicaCodigo = TABLEID24U2_A41ClinicaCodigo[0] ;
            A91ConsultaId = TABLEID24U2_A91ConsultaId[0] ;
            /*
               INSERT RECORD ON TABLE Aseguradora

            */
            W82AsegCodigo = A82AsegCodigo ;
            W83AsegNombre = A83AsegNombre ;
            W83AsegNombre = A83AsegNombre ;
            W84AsegDireccion = A84AsegDireccion ;
            W84AsegDireccion = A84AsegDireccion ;
            W85AsegTelefono1 = A85AsegTelefono1 ;
            W85AsegTelefono1 = A85AsegTelefono1 ;
            W86AsegTelefono2 = A86AsegTelefono2 ;
            W86AsegTelefono2 = A86AsegTelefono2 ;
            W87AsegNit = A87AsegNit ;
            W87AsegNit = A87AsegNit ;
            W88AsegContacto = A88AsegContacto ;
            W88AsegContacto = A88AsegContacto ;
            W89AsegCorreo = A89AsegCorreo ;
            W89AsegCorreo = A89AsegCorreo ;
            W90AsegEstado = A90AsegEstado ;
            W90AsegEstado = A90AsegEstado ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( A83AsegNombre)) )
            {
               A83AsegNombre = " " ;
            }
            else
            {
            }
            if ( String.IsNullOrEmpty(StringUtil.RTrim( A84AsegDireccion)) )
            {
               A84AsegDireccion = " " ;
            }
            else
            {
            }
            if ( String.IsNullOrEmpty(StringUtil.RTrim( A85AsegTelefono1)) )
            {
               A85AsegTelefono1 = " " ;
            }
            else
            {
            }
            if ( String.IsNullOrEmpty(StringUtil.RTrim( A86AsegTelefono2)) )
            {
               A86AsegTelefono2 = " " ;
            }
            else
            {
            }
            if ( String.IsNullOrEmpty(StringUtil.RTrim( A87AsegNit)) )
            {
               A87AsegNit = " " ;
            }
            else
            {
            }
            if ( String.IsNullOrEmpty(StringUtil.RTrim( A88AsegContacto)) )
            {
               A88AsegContacto = " " ;
            }
            else
            {
            }
            if ( String.IsNullOrEmpty(StringUtil.RTrim( A89AsegCorreo)) )
            {
               A89AsegCorreo = " " ;
            }
            else
            {
            }
            if ( (0==A90AsegEstado) )
            {
               A90AsegEstado = 0 ;
            }
            else
            {
            }
            /* Using cursor TABLEID24U3 */
            pr_default.execute(1, new Object[] {A82AsegCodigo, A83AsegNombre, A84AsegDireccion, A85AsegTelefono1, A86AsegTelefono2, A87AsegNit, A88AsegContacto, A89AsegCorreo, A90AsegEstado});
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
            A82AsegCodigo = W82AsegCodigo ;
            A83AsegNombre = W83AsegNombre ;
            A83AsegNombre = W83AsegNombre ;
            A84AsegDireccion = W84AsegDireccion ;
            A84AsegDireccion = W84AsegDireccion ;
            A85AsegTelefono1 = W85AsegTelefono1 ;
            A85AsegTelefono1 = W85AsegTelefono1 ;
            A86AsegTelefono2 = W86AsegTelefono2 ;
            A86AsegTelefono2 = W86AsegTelefono2 ;
            A87AsegNit = W87AsegNit ;
            A87AsegNit = W87AsegNit ;
            A88AsegContacto = W88AsegContacto ;
            A88AsegContacto = W88AsegContacto ;
            A89AsegCorreo = W89AsegCorreo ;
            A89AsegCorreo = W89AsegCorreo ;
            A90AsegEstado = W90AsegEstado ;
            A90AsegEstado = W90AsegEstado ;
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
         TABLEID24U2_A82AsegCodigo = new String[] {""} ;
         TABLEID24U2_A41ClinicaCodigo = new String[] {""} ;
         TABLEID24U2_A91ConsultaId = new int[1] ;
         A82AsegCodigo = "" ;
         A41ClinicaCodigo = "" ;
         W82AsegCodigo = "" ;
         W83AsegNombre = "" ;
         A83AsegNombre = "" ;
         W84AsegDireccion = "" ;
         A84AsegDireccion = "" ;
         W85AsegTelefono1 = "" ;
         A85AsegTelefono1 = "" ;
         W86AsegTelefono2 = "" ;
         A86AsegTelefono2 = "" ;
         W87AsegNit = "" ;
         A87AsegNit = "" ;
         W88AsegContacto = "" ;
         A88AsegContacto = "" ;
         W89AsegCorreo = "" ;
         A89AsegCorreo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tableid24updatereferentialintegrity__default(),
            new Object[][] {
                new Object[] {
               TABLEID24U2_A82AsegCodigo, TABLEID24U2_A41ClinicaCodigo, TABLEID24U2_A91ConsultaId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short W90AsegEstado ;
      private short A90AsegEstado ;
      private int A91ConsultaId ;
      private int GX_INS24 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A82AsegCodigo ;
      private String A41ClinicaCodigo ;
      private String W82AsegCodigo ;
      private String W83AsegNombre ;
      private String A83AsegNombre ;
      private String W84AsegDireccion ;
      private String A84AsegDireccion ;
      private String W85AsegTelefono1 ;
      private String A85AsegTelefono1 ;
      private String W86AsegTelefono2 ;
      private String A86AsegTelefono2 ;
      private String W87AsegNit ;
      private String A87AsegNit ;
      private String W88AsegContacto ;
      private String A88AsegContacto ;
      private String W89AsegCorreo ;
      private String A89AsegCorreo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] TABLEID24U2_A82AsegCodigo ;
      private String[] TABLEID24U2_A41ClinicaCodigo ;
      private int[] TABLEID24U2_A91ConsultaId ;
   }

   public class tableid24updatereferentialintegrity__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmTABLEID24U2 ;
          prmTABLEID24U2 = new Object[] {
          } ;
          Object[] prmTABLEID24U3 ;
          prmTABLEID24U3 = new Object[] {
          new Object[] {"@AsegCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AsegNombre",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AsegDireccion",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AsegTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AsegTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AsegNit",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AsegContacto",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AsegCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AsegEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TABLEID24U2", "SELECT [AsegCodigo], [ClinicaCodigo], [ConsultaId] FROM [Consulta] ORDER BY [ClinicaCodigo], [ConsultaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTABLEID24U2,100,0,true,false )
             ,new CursorDef("TABLEID24U3", "INSERT INTO [Aseguradora] ([AsegCodigo], [AsegNombre], [AsegDireccion], [AsegTelefono1], [AsegTelefono2], [AsegNit], [AsegContacto], [AsegCorreo], [AsegEstado]) VALUES (@AsegCodigo, @AsegNombre, @AsegDireccion, @AsegTelefono1, @AsegTelefono2, @AsegNit, @AsegContacto, @AsegCorreo, @AsegEstado)", GxErrorMask.GX_NOMASK,prmTABLEID24U3)
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                break;
       }
    }

 }

}
