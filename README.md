# DataGrid - How to use FileUploader as a cell editor

This example illustrates how to embed the [dxFileUploader](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxFileUploader/) widget into the [dxDataGrid's](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/) editing form to associate files with grid rows. 

*Files to look at*:

* [EmployeesController.cs](./mvc/Controllers/EmployeesController.cs)
* [JQuerySample.cshtml](./mvc/Views/Home/JQuerySample.cshtml)
* [MVCSample.cshtml](./mvc/Views/Home/MVCSample.cshtml)


The grid has the `Picture` field which holds the associated image file name. We specify the [cellTemplate](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/columns/#cellTemplate) to display the image as illustrated in the [Column Template](https://js.devexpress.com/Demos/WidgetsGallery/Demo/DataGrid/ColumnTemplate/jQuery/Light/) demo module. 

To implement the file upload UI/logic, we handle the [onEditorPreparing](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/#onEditorPreparing) event and enable the [dxFileUploader](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxFileUploader/) widget for the `Picture` field. We also handle the [dxFileUploader.onValueChanged](https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxFileUploader/Configuration/#onValueChanged) event to pass the current row key to the server.

The server part for the file uploading is implemented in the context of the `EmployeesController.Upload` method in the [EmployeesController.cs](mvc/Controllers/EmployeesController.cs) code file. 

**Note:** This example illustrtes the basic approach to upload files. It does not include any logic to handle file name conflicts or file preview functionality. You may need to implement special logic to save files with unique names. In this scenario, use the `key` argument passed to the `EmployeesController.Upload` method. You will also need to synchronize the client-side file name passed to the `e.setValue` method.

