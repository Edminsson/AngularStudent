Grunden.treeApp.directive("angularGrid", function () {
    return {
        link: function (scope, element) {
            var columns = [
              { id: "courseName", name: "Course Name", field: "courseName", width: 120, minWidth: 120, cssClass: "cell-title", editor: Slick.Editors.Text },
              { id: "credits", name: "Credits", field: "credits", width: 120, minWidth: 120, cssClass: "cell-title", editor: Slick.Editors.Text },
            ];

            var data = [];
            //for (var i = 0; i < 15; i++) {
            //    var d = (data[i] = {});
            //    d["courseName"] = "Task " + i;
            //    d["credits"] = "5 days";
            //}

            var options = {
                editable: true,
                enableAddRow: true,
                enableCellNavigation: true,
                asyncEditorLoading: true,
                forceFitColumns: false,
                topPanelHeight: 25
            };
            dataView = new Slick.Data.DataView({ inlineFilters: true });
            grid = new Slick.Grid("#myGrid", dataView, columns, options);
            grid.setSelectionModel(new Slick.RowSelectionModel());
            // wire up model events to drive the grid
            dataView.onRowCountChanged.subscribe(function (e, args) {
                grid.updateRowCount();
                grid.render();
            });
            dataView.onRowsChanged.subscribe(function (e, args) {
                grid.invalidateRows(args.rows);
                grid.render();
            });

            // initialize the model after all the events have been hooked up
            dataView.beginUpdate();
            dataView.setItems(data);
            dataView.endUpdate();

            //scope.$watch("model.person", function () { console.log('en ändring har skett') })
            scope.$watch("model.enrollments", function () {
                if (scope.model && scope.model.enrollments && scope.model.enrollments.length > 0) {
                    angular.copy(scope.model.enrollments, data);
                }
                else {
                    data = [];
                }
                console.log('Direktiv säger: ändring')
                dataView.beginUpdate();
                dataView.setItems(data);
                dataView.endUpdate();
                grid.invalidate();
                grid.render();
            }, true);
        }
    };
});

Grunden.treeApp.directive("aGrid", function () {
    return {
        link: function (scope, element) {

            //scope.$watch("namn", function () {
            //    console.log('Direktiv säger: namnändring')
            //});
            scope.$watch("model.enrollments", function () {
                console.log('Direktiv säger: ändring')
                if (scope.model && scope.model.enrollments && scope.model.enrollments.length > 0)
                {
                    element.text('Course Name: ' + scope.model.enrollments[0].courseName);
                }
            }, true);
        }
    };
});