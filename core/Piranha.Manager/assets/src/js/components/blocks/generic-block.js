Vue.component("generic-block", {
	props: ["uid", "toolbar", "model"],
	methods: {
		update: function () {
			if (this.model.displayTitleField) {
				this.model.meta.title = this.model.displayTitleField.model.value;
			}
		}
	},
	mounted: function () {
		if (this.model.displayTitleProperty) {
			var displayTitleField = null;

			for (var index in this.model.fields) {
				if (this.model.fields[index].meta.id === this.model.displayTitleProperty) {
					displayTitleField = this.model.fields[index];
					break;
				}
			}

			if (displayTitleField) {
				this.model.displayTitleField = displayTitleField;
			} else {
				console.warn("Generic Block '" + this.model.meta.name + "': could not find field with id '" + this.model.displayTitleProperty + "' when updating display title");
			}
		} else {
			console.log("Generic Block '" + this.model.meta.name + "': no display title property set; title will remain static");
		}
	},
	template:
		"<div :id='uid' class='block-group'>" +
		"  <div class='row'>" +
		"    <div class='form-group' :class='{ \"col-sm-6\": field.meta.isHalfWidth, \"col-sm-12\": !field.meta.isHalfWidth }' v-for='field in model.fields'>" +
		"      <label>{{ field.meta.name }}</label>" +
		"      <div v-if='field.meta.description != null' v-html='field.meta.description' class='field-description small text-muted'></div>" +
		"      <component v-bind:is='field.meta.component' v-bind:uid='field.meta.uid' v-bind:meta='field.meta' v-bind:toolbar='toolbar' v-bind:model='field.model' v-on:update-field='update()'></component>" +
		"    </div>" +
		"  </div>" +
		"</div>"
});
