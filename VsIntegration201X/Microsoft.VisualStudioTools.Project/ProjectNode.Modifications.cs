namespace Microsoft.VisualStudioTools.Project
{
    partial class ProjectNode
    {
        protected internal void SetOpened()
        {
            this.projectOpened = true;
        }

        protected internal void SetIsDirty(bool isDirty)
        {
            this.isDirty = isDirty;
        }
    }
}
