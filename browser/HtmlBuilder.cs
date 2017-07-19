using System;
using System.Linq;
using System.Text;

namespace MantisSharp.Browser
{
  internal sealed class HtmlBuilder
  {
    #region Methods

    public string BuildHtml(Issue issue)
    {
      StringBuilder sb;

      sb = new StringBuilder();

      // TODO: Could use HtmlTextWriter, but that means system.web

      sb.AppendLine("<!doctype html>");
      this.WriteTag(sb, "html", () =>
                                {
                                  this.WriteTag(sb, "head", () =>
                                                            {
                                                              // css reset: http://meyerweb.com/eric/tools/css/reset/
                                                              this.WriteStyle(sb, "a,abbr,acronym,address,applet,article,aside,audio,b,big,blockquote,body,canvas,caption,center,cite,code,dd,del,details,dfn,div,dl,dt,em,embed,fieldset,figcaption,figure,footer,form,h1,h2,h3,h4,h5,h6,header,hgroup,html,i,iframe,img,ins,kbd,label,legend,li,mark,menu,nav,object,ol,output,p,pre,q,ruby,s,samp,section,small,span,strike,strong,sub,summary,sup,table,tbody,td,tfoot,th,thead,time,tr,tt,u,ul,var,video{margin:0;padding:0;border:0;font:inherit;vertical-align:baseline}article,aside,details,figcaption,figure,footer,header,hgroup,menu,nav,section{display:block}body{line-height:1}ol,ul{list-style:none}blockquote,q{quotes:none}blockquote:after,blockquote:before,q:after,q:before{content:'';content:none}table{border-collapse:collapse;border-spacing:0}");
                                                              this.WriteStyle(sb, "body { background-color: ButtonFace; color: ButtonText; font-family: tahoma; font-size: 8pt;} table { width: 100%; margin-bottom: 1em; } td, th { border: 1px solid #999; padding: 0.5em; text-align: left; } h2 { font-size: 10pt; margin-bottom: 0.5em; }");
                                                            });

                                  this.WriteTag(sb, "body", () =>
                                                            {
                                                              this.BuildIssueDetailsTable(sb, issue);
                                                              this.BuildIssueRelationshipsTable(sb, issue);
                                                              this.BuildIssueMonitorsTable(sb, issue);
                                                              this.BuildIssueNotesTable(sb, issue);
                                                              this.BuildIssueAttachmentsTable(sb, issue);
                                                            });
                                });

      return sb.ToString();
    }

    private void BuildIssueAttachmentsTable(StringBuilder sb, Issue issue)
    {
      if (issue.Attachments != null && issue.Attachments.Count > 0)
      {
        this.WriteH2(sb, "Attachments");
        this.WriteTable(sb, () =>
                            {
                              this.WriteTableRow(sb, "Created", "Created By", "File", "Size", "Content Type");
                              foreach (Attachment attachment in issue.Attachments)
                              {
                                this.WriteTableRow(sb, attachment.Created, attachment.Reporter, "<a href=\"" + attachment.DownloadUrl + "\" title=\"" + attachment.DownloadUrl + "\">" + attachment.FileName + "</a>", attachment.Size, attachment.ContentType);
                              }
                            });
      }
    }

    private void BuildIssueDetailsTable(StringBuilder sb, Issue issue)
    {
      this.WriteH2(sb, "Issue Details");
      this.WriteTable(sb, () =>
                          {
                            this.WriteTableRow(sb, "Id", "Project", "Category", "View Status", "Created", "Updated");
                            this.WriteTableRow(sb, issue.Id, issue.Project, issue.Category, issue.ViewState, issue.Created, issue.LastModified);
                          });

      this.WriteTable(sb, () =>
                          {
                            this.WriteTableRow(sb, "Reporter", issue.Reporter, "Assigned To", issue.AssignedTo, string.Empty, string.Empty);
                            this.WriteTableRow(sb, "Priority", issue.Priority, "Severity", issue.Severity, "Reproducability", issue.Reproducibility);
                            this.WriteTableRow(sb, "Status", issue.Status, "Resolution", issue.Resolution, string.Empty, string.Empty);
                            this.WriteTableRow(sb, "Platform", issue.Platform, "OS", issue.OperatingSystem, "OS Version", issue.OperatingSystemBuild);
                          });

      this.WriteTable(sb, () =>
                          {
                            this.WriteTableRow(sb, "Summary", issue.Summary);
                            if (!string.IsNullOrEmpty(issue.Description))
                            {
                              this.WriteTableRow(sb, "Description", issue.Description);
                            }
                            if (!string.IsNullOrEmpty(issue.StepsToReproduce))
                            {
                              this.WriteTableRow(sb, "Steps To Reproduce", issue.StepsToReproduce);
                            }
                            if (!string.IsNullOrEmpty(issue.AdditionalInformation))
                            {
                              this.WriteTableRow(sb, "Additional Information", issue.AdditionalInformation);
                            }
                            if (issue.Tags != null && issue.Tags.Count > 0)
                            {
                              this.WriteTableRow(sb, "Tags", string.Join(", ", issue.Tags));
                            }
                          });
    }

    private void BuildIssueMonitorsTable(StringBuilder sb, Issue issue)
    {
      if (issue.Monitors != null && issue.Monitors.Count > 0)
      {
        this.WriteH2(sb, "Users monitoring this issue");
        this.WriteTable(sb, () => { this.WriteTableRow(sb, "User List", string.Join(", ", issue.Monitors.Select(user => user.Name))); });
      }
    }

    private void BuildIssueNotesTable(StringBuilder sb, Issue issue)
    {
      if (issue.Notes != null && issue.Notes.Count > 0)
      {
        this.WriteH2(sb, "Notes");
        this.WriteTable(sb, () =>
                            {
                              this.WriteTableRow(sb, "Created", "Modified", "Created By", "Note");
                              foreach (Note note in issue.Notes)
                              {
                                this.WriteTableRow(sb, note.Created, note.LastModified, note.Reporter, note.Text);
                              }
                            });
      }
    }

    private void BuildIssueRelationshipsTable(StringBuilder sb, Issue issue)
    {
      if (issue.Relationships != null && issue.Relationships.Count > 0)
      {
        this.WriteH2(sb, "Relationships");
        this.WriteTable(sb, () =>
                            {
                              foreach (Relationship relationship in issue.Relationships)
                              {
                                this.WriteTableRow(sb, relationship.RelationshipType, relationship.TargetId);
                              }
                            });
      }
    }

    private void WriteH2(StringBuilder sb, string text)
    {
      this.WriteTag(sb, "h2", () => sb.Append(text));
    }

    private void WriteStyle(StringBuilder sb, string css)
    {
      this.WriteTag(sb, "style", () => sb.Append(css));
    }

    private void WriteTable(StringBuilder sb, Action action)
    {
      this.WriteTag(sb, "table", action);
    }

    private void WriteTableRow(StringBuilder sb, params string[] cells)
    {
      this.WriteTag(sb, "tr", () =>
                              {
                                for (int i = 0; i < cells.Length; i++)
                                {
                                  this.WriteTag(sb, "td", () => sb.Append(cells[i]));
                                }
                              });
    }

    private void WriteTableRow(StringBuilder sb, params object[] cells)
    {
      this.WriteTag(sb, "tr", () =>
                              {
                                for (int i = 0; i < cells.Length; i++)
                                {
                                  this.WriteTag(sb, "td", () => sb.Append(cells[i]));
                                }
                              });
    }

    private void WriteTag(StringBuilder sb, string tagName, Action action)
    {
      sb.AppendLine("<" + tagName + ">");

      action();

      sb.AppendLine("</" + tagName + ">");
    }

    #endregion
  }
}
