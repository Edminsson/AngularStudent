$(function () {
	// Attach the dynatree widget to an existing <div id="tree"> element
	// and pass the tree options as an argument to the dynatree() function:
	$("#tree").dynatree({
		onActivate: function (node) {
			// A DynaTreeNode object is passed to the activation handler
			// Note: we also get this event, if persistence is on, and the page is reloaded.
			window.location.href = "#/student/"+ node.data.id;
		},
		persist: true,
		initAjax: {url:"/Tree/LoadData"}
	});
});
